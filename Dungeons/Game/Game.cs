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
        public Weapon WeaponInRoom;

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }

        bool shieldUsed = false;

        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70));
            createLevels = new CreateLevels(this);
        }

        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            foreach(Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
        }      

        public void HitPlayer(int maxDamage, Random random)
        {
            player.Hit(maxDamage, random);
        }

        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }

        public bool CheckUsedDisposable()
        {
            return player.CheckUsedDisposable();
        }

        public string ChoosenWeaponByPlayer()
        {
            return player.ChoosenWeapon();
        }

        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
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

        public void ActivatePlayerShield(int armour)
        {
            if (shieldUsed == false)
            {
                player.ActivateShield(armour, false);
                shieldUsed = true;
            }
            else
                player.ActivateShield(armour, true);                      
        }

        public int PointOfShield()
        {
            return player.CheckArmour;
        }

        public void DestroyShield()
        {
            shieldUsed = false;
        }

        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);
            foreach(Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
        }

        public void NewLevel(Random random)
        {
            level++;
            createLevels.NewLevel(random, level);
        }        
    }
}
