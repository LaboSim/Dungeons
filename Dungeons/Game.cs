﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Dungeons
{
    class Game
    {
        private Player player;
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        private int level = 0;
        public int Level { get { return level; } }
        public List<Enemy> Enemies;

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }

        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70));
        }

        public void Move(Direction direction, Random random)
        {
            player.Move(direction);

            foreach(Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
        }

        private Point GetRandomLocation(Random random)
        {
            return new Point(boundaries.Left + random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
                boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        }

        public void NewLevel(Random random)
        {
            level++;
            switch (level)
            {
                case 1:
                    {
                        Enemies = new List<Enemy>();
                        Enemies.Add(new Bat(this, GetRandomLocation(random)));
                        break;
                    }
            }
        }
    }
}