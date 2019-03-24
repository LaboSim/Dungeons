﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Dungeons
{
    abstract class Mover
    {
        private const int MoveInterval = 10;
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;

        public Mover(Game game, Point location)
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

        public bool Nearby(Point enemyLocation, Point targetLocation, int distance)
        {
            if (Math.Abs(enemyLocation.X - targetLocation.X) < distance &&
                (Math.Abs(enemyLocation.Y - targetLocation.Y) < distance))
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
                        if (newlocation.Y - MoveInterval >= boundaries.Top)
                            newlocation.Y -= MoveInterval;
                        break;
                    }
                case Direction.Down:
                    {
                        if (newlocation.Y + MoveInterval <= boundaries.Bottom)
                            newlocation.Y += MoveInterval;
                        break;
                    }
                case Direction.Left:
                    {
                        if (newlocation.X - MoveInterval >= boundaries.Left)
                            newlocation.X -= MoveInterval;
                        break;
                    }
                case Direction.Right:
                    {
                        if (newlocation.X + MoveInterval <= boundaries.Right)
                            newlocation.X += MoveInterval;
                        break;
                    }
            }
            return newlocation;
        }

        public Point Move(Direction direction, Point playerLocation, Rectangle boundaries)
        {
            Point newlocation = playerLocation;

            switch (direction)
            {
                case Direction.Up:
                    {
                        if (newlocation.Y - MoveInterval >= boundaries.Top)
                            newlocation.Y -= MoveInterval;
                        break;
                    }
                case Direction.Down:
                    {
                        if (newlocation.Y + MoveInterval <= boundaries.Bottom)
                            newlocation.Y += MoveInterval;
                        break;
                    }
                case Direction.Left:
                    {
                        if (newlocation.X - MoveInterval >= boundaries.Left)
                            newlocation.X -= MoveInterval;
                        break;
                    }
                case Direction.Right:
                    {
                        if (newlocation.X + MoveInterval <= boundaries.Right)
                            newlocation.X += MoveInterval;
                        break;
                    }
            }
            return newlocation;
        }
    }
}
