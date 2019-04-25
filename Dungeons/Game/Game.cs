using System;
using System.Collections.Generic;
using System.Drawing;

namespace Dungeons
{
    class Game
    {
        private Player player;
        private CreateLevels createLevels;

        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }

        private int level = 0;
        public int Level { get { return level; } }

        public List<Enemy> Enemies;
        public Item ItemInRoom;

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }

        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            // 10 and 70 is ,,random" number to set the starting location of player
            player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70));
            createLevels = new CreateLevels(this);
        }

        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            EnemyMoves(random);           
        }  
        
        private void EnemyMoves(Random random)
        {
            foreach (Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
        }

        public void HitPlayer(int maxDamage, Random random)
        {
            player.Hit(maxDamage, random);
        }

        public void Equip(string itemName)
        {
            player.Equip(itemName);
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

        public string ChoosenItemByPlayer()
        {
            return player.ChoosenItem();
        }

        public bool CheckPlayerInventory(string itemName)
        {
            return player.Items.Contains(itemName);
        }

        public int CheckNumberOfArrows()
        {
            return player.NumberOfArrows;
        }

        public void IncreasePlayerHealth(int health, Random random)
        {
            player.IncreaseHealth(health, random);
        }

        public void IncreasePlayerNumberOfArrows(int number, Random random)
        {
            player.IncreaseNumberOfArrows(number, random);
        }

        public void DestroyArmour()
        {
            player.DestroyArmour();
        }  
        
        public int PointsOfArmour { get; set; }

        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);
            EnemyMoves(random);
        }

        public void NewLevel(Random random)
        {
            level++;
            createLevels.NewLevel(random, level);
        }        
    }
}
