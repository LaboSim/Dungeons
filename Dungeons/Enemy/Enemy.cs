using System;
using System.Drawing;

namespace Dungeons
{
    abstract class Enemy : Movement
    {
        private const int nearPlayerDistance = 25;
        public int HitPoints { get; private set; }
        public int ReceivedAttackByEnemy { get; private set; }

        public Enemy(Game game, Point location, int hitPoints) : base(game, location)
        {
            this.HitPoints = hitPoints;
        }

        public abstract void Move(Random random);

        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
            PlayerStatistics.SuccessfulAttackPlayer++;
        }           

        protected bool NearPlayer()
        {
            return (Nearby(game.PlayerLocation, nearPlayerDistance));
        }

        //10 to increase chance to find player location by enemy
        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directionToMove;

            if (playerLocation.X > location.X + 10)
                directionToMove = Direction.Right;
            else if (playerLocation.X < location.X - 10)
                directionToMove = Direction.Left;
            else if (playerLocation.Y < location.Y - 10)
                directionToMove = Direction.Up;
            else
                directionToMove = Direction.Down;

            return directionToMove;
        }
    }
}
