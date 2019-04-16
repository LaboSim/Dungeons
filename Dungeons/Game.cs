using System;
using System.Collections.Generic;
using System.Drawing;

namespace Dungeons
{
    class Game
    {
        private Player player;

        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }

        public int NumberOfPlayerMoves { get { return player.NumberOfMoves; } }
        public int NumberOfAttackSuccessful { get; set; }
        public int NumberOfAttack { get { return player.NumberOfAttack; } }

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
            switch (level)
            {
                case 1:
                    {
                        Enemies = new List<Enemy>();                    
                        Enemies.Add(new Bat(this, GetRandomLocation(random)));
                        WeaponInRoom = new Sword(this, GetRandomLocation(random));
                        break;
                    }
                case 2:
                    {
                        Enemies.Clear();
                        Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                        WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                        break;
                    }
                case 3:
                    {
                        Enemies.Clear();
                        Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                        WeaponInRoom = new Bow(this, GetRandomLocation(random));
                        break;
                    }
                case 4:
                    {
                        Enemies.Clear();
                        Enemies.Add(new Bat(this, GetRandomLocation(random)));
                        Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                        if (CheckPlayerInventory("Bow"))
                        {
                            if (CheckPlayerInventory("Blue potion"))
                                ;
                            else
                                WeaponInRoom = new BluePotion(this, GetRandomLocation(random));                         
                        }
                        else
                            WeaponInRoom = new Bow(this, GetRandomLocation(random));                            
                        break;
                    }
                case 5:
                    {
                        Enemies.Clear();
                        Enemies.Add(new Bat(this, GetRandomLocation(random)));
                        Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                        WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                        break;
                    }
                case 6:
                    {
                        Enemies.Clear();
                        Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                        Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                        WeaponInRoom = new Mace(this, GetRandomLocation(random));
                        break;
                    }
                case 7:
                    {
                        Enemies.Clear();
                        Enemies.Add(new Bat(this, GetRandomLocation(random)));
                        Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                        Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                        if (CheckPlayerInventory("Mace"))
                        {
                            if (CheckPlayerInventory("Red potion"))
                                ;
                            else
                                WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                        }
                        else
                            WeaponInRoom = new Mace(this, GetRandomLocation(random));
                        break;
                    }
               case 8:
                    {
                        Enemies.Clear();
                        Enemies.Add(new Wizard(this, GetRandomLocation(random)));
                        if(CheckPlayerInventory("Bow"))
                            WeaponInRoom = new Quiver(this, GetRandomLocation(random));
                        break;
                    }
                case 9:
                    {
                        Enemies.Clear();
                        Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                        Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                        if (CheckPlayerInventory("Bow"))
                            WeaponInRoom = new Shield(this, GetRandomLocation(random), 5);
                        else
                            WeaponInRoom = new Bow(this, GetRandomLocation(random));
                        break;
                    }
                case 10:
                    {
                        Enemies.Clear();
                        Enemies.Add(new Wizard(this, GetRandomLocation(random)));
                        Enemies.Add(new Bat(this, GetRandomLocation(random)));
                        if (CheckPlayerInventory("Red potion"))
                            WeaponInRoom = new BattleAxe(this, GetRandomLocation(random));
                        else
                            WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                        break;
                    }
                case 11:
                    {
                        Enemies.Clear();
                        Enemies.Add(new Wizard(this, GetRandomLocation(random)));
                        Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                        if (CheckPlayerInventory("Battle axe"))
                            ;
                        else
                            WeaponInRoom = new BattleAxe(this, GetRandomLocation(random));
                        break;
                    }
                case 12:
                    {
                        Enemies.Clear();
                        Enemies.Add(new Bat(this, GetRandomLocation(random)));
                        Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                        Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                        if (CheckPlayerInventory("Bow"))
                        {
                            if (CheckPlayerInventory("Quiver"))
                                ;
                            else
                                WeaponInRoom = new Quiver(this, GetRandomLocation(random));
                        }
                        break;
                    }
                case 13:
                    {
                        Enemies = new List<Enemy>();
                        Enemies.Add(new Bat(this, GetRandomLocation(random)));
                        WeaponInRoom = new Bomb(this, GetRandomLocation(random));
                        break;
                    }
                case 14:
                    {
                        Enemies = new List<Enemy>();
                        Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                        Enemies.Add(new Wizard(this, GetRandomLocation(random)));
                        if (CheckPlayerInventory("Blue potion"))
                        {
                            if (CheckPlayerInventory("Shield"))
                                ;
                            else
                                WeaponInRoom = new Shield(this, GetRandomLocation(random), 5);
                        }
                        else
                            WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                        break;
                    }
                case 15:
                    {
                        Enemies.Clear();
                        Enemies.Add(new Bat(this, GetRandomLocation(random)));
                        Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                        Enemies.Add(new Wizard(this, GetRandomLocation(random)));
                        if (CheckPlayerInventory("Battle axe"))
                        {
                            if (CheckPlayerInventory("Bow"))
                            {
                                if (CheckPlayerInventory("Quiver"))
                                    ;
                                else
                                    WeaponInRoom = new Quiver(this, GetRandomLocation(random));
                            }
                        }
                        else
                            WeaponInRoom = new BattleAxe(this, GetRandomLocation(random));
                        break;
                    }
                case 16:
                    {
                        Enemies.Clear();
                        Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                        Enemies.Add(new Wizard(this, GetRandomLocation(random)));
                        Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                        if (CheckPlayerInventory("Bomb"))
                        {
                            if (CheckPlayerInventory("Red potion"))
                            {
                                if (CheckPlayerInventory("Blue potion"))
                                    ;
                                else
                                    WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                            }
                            else
                                WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                        }
                        else
                            WeaponInRoom = new Bomb(this, GetRandomLocation(random));
                        break;
                    }
                case 17:
                    {
                        Enemies.Clear();
                        Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                        Enemies.Add(new Wizard(this, GetRandomLocation(random)));
                        Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                        Enemies.Add(new Bat(this, GetRandomLocation(random)));
                        if (CheckPlayerInventory("Shield"))
                        {
                            if (CheckPlayerInventory("Bow"))
                            {
                                if (CheckPlayerInventory("Quiver"))
                                    ;
                                else
                                    WeaponInRoom = new Quiver(this, GetRandomLocation(random));
                            }
                        }
                        else
                            WeaponInRoom = new Shield(this, GetRandomLocation(random), 5);
                        break;
                    }
                case 18:
                    {
                        Enemies.Clear();
                        break;
                    }
            }
        }
    }
}
