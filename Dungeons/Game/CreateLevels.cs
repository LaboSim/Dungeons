using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons
{
    class CreateLevels
    {
        private Game game;

        public CreateLevels(Game Game)
        {
            this.game = Game;
        }

        private Point GetRandomLocation(Random random)
        {
            return new Point(game.Boundaries.Left + random.Next(game.Boundaries.Right / 10 - game.Boundaries.Left / 10) * 10,
                game.Boundaries.Top + random.Next(game.Boundaries.Bottom / 10 - game.Boundaries.Top / 10) * 10);
        }

        public void NewLevel(Random random, int level)
        {
            switch (level)
            {
                case 1:
                    {
                        game.Enemies = new List<Enemy>();
                        game.Enemies.Add(new Bat(game, GetRandomLocation(random)));
                        game.WeaponInRoom = new Sword(game, GetRandomLocation(random));
                        break;
                    }
                case 2:
                    {
                        game.Enemies.Clear();
                        game.Enemies.Add(new Ghost(game, GetRandomLocation(random)));
                        game.WeaponInRoom = new BluePotion(game, GetRandomLocation(random));
                        break;
                    }
                case 3:
                    {
                        game.Enemies.Clear();
                        game.Enemies.Add(new Ghoul(game, GetRandomLocation(random)));
                        game.WeaponInRoom = new Bow(game, GetRandomLocation(random));
                        break;
                    }
                case 4:
                    {
                        game.Enemies.Clear();
                        game.Enemies.Add(new Bat(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghost(game, GetRandomLocation(random)));
                        if (game.CheckPlayerInventory("Bow"))
                        {
                            if (game.CheckPlayerInventory("Blue potion"))
                                ;
                            else
                                game.WeaponInRoom = new BluePotion(game, GetRandomLocation(random));
                        }
                        else
                            game.WeaponInRoom = new Bow(game, GetRandomLocation(random));
                        break;
                    }
                case 5:
                    {
                        game.Enemies.Clear();
                        game.Enemies.Add(new Bat(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghoul(game, GetRandomLocation(random)));
                        game.WeaponInRoom = new RedPotion(game, GetRandomLocation(random));
                        break;
                    }
                case 6:
                    {
                        game.Enemies.Clear();
                        game.Enemies.Add(new Ghost(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghoul(game, GetRandomLocation(random)));
                        game.WeaponInRoom = new Mace(game, GetRandomLocation(random));
                        break;
                    }
                case 7:
                    {
                        game.Enemies.Clear();
                        game.Enemies.Add(new Bat(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghost(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghoul(game, GetRandomLocation(random)));
                        if (game.CheckPlayerInventory("Mace"))
                        {
                            if (game.CheckPlayerInventory("Red potion"))
                                ;
                            else
                                game.WeaponInRoom = new RedPotion(game, GetRandomLocation(random));
                        }
                        else
                            game.WeaponInRoom = new Mace(game, GetRandomLocation(random));
                        break;
                    }
                case 8:
                    {
                        game.Enemies.Clear();
                        game.Enemies.Add(new Wizard(game, GetRandomLocation(random)));
                        if (game.CheckPlayerInventory("Bow"))
                            game.WeaponInRoom = new Quiver(game, GetRandomLocation(random));
                        break;
                    }
                case 9:
                    {
                        game.Enemies.Clear();
                        game.Enemies.Add(new Ghost(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghoul(game, GetRandomLocation(random)));
                        if (game.CheckPlayerInventory("Bow"))
                            game.WeaponInRoom = new Shield(game, GetRandomLocation(random), 5);
                        else
                            game.WeaponInRoom = new Bow(game, GetRandomLocation(random));
                        break;
                    }
                case 10:
                    {
                        game.Enemies.Clear();
                        game.Enemies.Add(new Wizard(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Bat(game, GetRandomLocation(random)));
                        if (game.CheckPlayerInventory("Red potion"))
                            game.WeaponInRoom = new BattleAxe(game, GetRandomLocation(random));
                        else
                            game.WeaponInRoom = new RedPotion(game, GetRandomLocation(random));
                        break;
                    }
                case 11:
                    {
                        game.Enemies.Clear();
                        game.Enemies.Add(new Wizard(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghost(game, GetRandomLocation(random)));
                        if (game.CheckPlayerInventory("Battle axe"))
                            ;
                        else
                            game.WeaponInRoom = new BattleAxe(game, GetRandomLocation(random));
                        break;
                    }
                case 12:
                    {
                        game.Enemies.Clear();
                        game.Enemies.Add(new Bat(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghost(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghoul(game, GetRandomLocation(random)));
                        if (game.CheckPlayerInventory("Bow"))
                        {
                            if (game.CheckPlayerInventory("Quiver"))
                                ;
                            else
                                game.WeaponInRoom = new Quiver(game, GetRandomLocation(random));
                        }
                        break;
                    }
                case 13:
                    {
                        game.Enemies = new List<Enemy>();
                        game.Enemies.Add(new Bat(game, GetRandomLocation(random)));
                        game.WeaponInRoom = new Bomb(game, GetRandomLocation(random));
                        break;
                    }
                case 14:
                    {
                        game.Enemies = new List<Enemy>();
                        game.Enemies.Add(new Ghoul(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Wizard(game, GetRandomLocation(random)));
                        if (game.CheckPlayerInventory("Blue potion"))
                        {
                            if (game.CheckPlayerInventory("Shield"))
                                ;
                            else
                                game.WeaponInRoom = new Shield(game, GetRandomLocation(random), 5);
                        }
                        else
                            game.WeaponInRoom = new BluePotion(game, GetRandomLocation(random));
                        break;
                    }
                case 15:
                    {
                        game.Enemies.Clear();
                        game.Enemies.Add(new Bat(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghost(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Wizard(game, GetRandomLocation(random)));
                        if (game.CheckPlayerInventory("Battle axe"))
                        {
                            if (game.CheckPlayerInventory("Bow"))
                            {
                                if (game.CheckPlayerInventory("Quiver"))
                                    ;
                                else
                                    game.WeaponInRoom = new Quiver(game, GetRandomLocation(random));
                            }
                        }
                        else
                            game.WeaponInRoom = new BattleAxe(game, GetRandomLocation(random));
                        break;
                    }
                case 16:
                    {
                        game.Enemies.Clear();
                        game.Enemies.Add(new Ghost(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Wizard(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghoul(game, GetRandomLocation(random)));
                        if (game.CheckPlayerInventory("Bomb"))
                        {
                            if (game.CheckPlayerInventory("Red potion"))
                            {
                                if (game.CheckPlayerInventory("Blue potion"))
                                    ;
                                else
                                    game.WeaponInRoom = new BluePotion(game, GetRandomLocation(random));
                            }
                            else
                                game.WeaponInRoom = new RedPotion(game, GetRandomLocation(random));
                        }
                        else
                            game.WeaponInRoom = new Bomb(game, GetRandomLocation(random));
                        break;
                    }
                case 17:
                    {
                        game.Enemies.Clear();
                        game.Enemies.Add(new Ghost(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Wizard(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghoul(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Bat(game, GetRandomLocation(random)));
                        if (game.CheckPlayerInventory("Shield"))
                        {
                            if (game.CheckPlayerInventory("Bow"))
                            {
                                if (game.CheckPlayerInventory("Quiver"))
                                    ;
                                else
                                    game.WeaponInRoom = new Quiver(game, GetRandomLocation(random));
                            }
                        }
                        else
                            game.WeaponInRoom = new Shield(game, GetRandomLocation(random), 5);
                        break;
                    }
                case 18:
                    {
                        game.Enemies.Clear();
                        break;
                    }
            }
        }
    }
}
