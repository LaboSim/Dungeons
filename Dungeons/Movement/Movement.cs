using System;
using System.Drawing;

namespace Dungeons
{
    abstract class Movement
    {
        #region Fields and Properties
        private const int moveInterval = 10;
        protected Point location;
        protected Game game;
        public Point Location { get { return location; } }
        #endregion

        public Movement(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }

        public bool Nearby(Point locationToCheck, int distance)
        {
            if (Math.Abs(location.X - locationToCheck.X) < distance &&
                (Math.Abs(location.Y - locationToCheck.Y) < distance))
                return true;
            else
                return false;
        }

        public Point Move(Direction direction, Rectangle boundaries)
        {
            Point newlocation = location;

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
    }
}
