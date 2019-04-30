using System;
using System.Drawing;

namespace Dungeons
{
    abstract class DamageForEnemy : Item
    {
        private const int moveInterval = 10;

        public DamageForEnemy(Game game, Point location) : base(game, location)
        {

        }

        protected bool Nearby(Point enemyLocation, Point targetLocation, int distance)
        {
            if (Math.Abs(enemyLocation.X - targetLocation.X) < distance &&
                (Math.Abs(enemyLocation.Y - targetLocation.Y) < distance))
                return true;
            else
                return false;
        }
        
        protected Point ChangeLocationToDealDamage(Direction direction, Point playerLocation, Rectangle boundaries)
        {
            Point newlocation = playerLocation;

            switch (direction)
            {
                case Direction.Up:
                    {
                        if (newlocation.Y - moveInterval >= boundaries.Top)
                            newlocation.Y -= moveInterval;
                        break;
                    }
                case Direction.Down:
                    {
                        if (newlocation.Y + moveInterval <= boundaries.Bottom)
                            newlocation.Y += moveInterval;
                        break;
                    }
                case Direction.Left:
                    {
                        if (newlocation.X - moveInterval >= boundaries.Left)
                            newlocation.X -= moveInterval;
                        break;
                    }
                case Direction.Right:
                    {
                        if (newlocation.X + moveInterval <= boundaries.Right)
                            newlocation.X += moveInterval;
                        break;
                    }
            }
            return newlocation;
        }

        protected bool DamageEnemy(Direction direction, int range, int damage, Random random)
        {
            Point target = game.PlayerLocation;

            for (int distance = 0; distance < range; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (Nearby(enemy.Location, target, distance))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                target = ChangeLocationToDealDamage(direction, target, game.Boundaries);
            }
            return false;
        }
    }
}
