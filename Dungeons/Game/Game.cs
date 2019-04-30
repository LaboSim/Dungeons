using System;
using System.Collections.Generic;
using System.Drawing;

namespace Dungeons
{
    class Game
    {
        /// <summary>
        /// Magages the gameplay
        /// </summary>
        #region Fields and Properties
        private Player player;
        private Levels createLevels;

        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }

        public int NumberOfArrows { get; set; }
        public int PointsOfArmour { get; set; }

        private int level = 0;
        public int Level { get { return level; } }

        public List<Enemy> Enemies;
        public Item ItemInRoom;

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }
        #endregion

        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            // 10 and 70 is ,,random" number to set the starting location of player
            player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70));
            createLevels = new Levels(this, player);
        }

        #region Actions of gameplay
        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            EnemyMoves(random);           
        }

        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);
            EnemyMoves(random);
        }

        public bool UseDisposable(Random random)
        {
            bool used = player.UseDisposable(random);
            EnemyMoves(random);
            return used;
        }

        public bool DetonateBomb(Random random)
        {
            bool used = player.DetonateBomb(random);
            EnemyMoves(random);
            return used;
        }
        #endregion

        public void HitPlayer(int maxDamage, Random random)
        {
            player.Hit(maxDamage, random);
        }      

        private void EnemyMoves(Random random)
        {
            foreach (Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
        }

        #region Equipment activities
        public void Equip(string itemName)
        {
            player.Equip(itemName);
        }

        public string ChoosenItemByPlayer()
        {
            return player.ChoosenItem();
        }

        public bool CheckPlayerInventory(string itemName)
        {
            return player.Items.Contains(itemName);
        }
        #endregion

        public void NewLevel(Random random)
        {
            level++;
            createLevels.NewLevel(random, level);
        }        
    }
}
