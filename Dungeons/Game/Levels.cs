using System;
using System.Collections.Generic;
using System.Drawing;

namespace Dungeons
{
    class Levels
    {
        private Game game;

        public Levels(Game game)
        {
            this.game = game;
        }

        // get random location inside the rectangle of the board that's why I added 10 - mathematical trick
        private Point GetRandomLocation(Random random)
        {
            return new Point(game.Boundaries.Left + random.Next(game.Boundaries.Right / 10 - game.Boundaries.Left / 10) * 10,
                game.Boundaries.Top + random.Next(game.Boundaries.Bottom / 10 - game.Boundaries.Top / 10) * 10);
        }

        public void NewLevel(Random random, int level)
        {
            game.Enemies = new List<Enemy>();
            switch (level)
            {
                case 1:
                    {                        
                        game.Enemies.Add(new Bat(game, GetRandomLocation(random)));
                        game.ItemInRoom = new Sword(game, GetRandomLocation(random));
                        break;
                    }
                case 2:
                    {
                        game.Enemies.Add(new Ghost(game, GetRandomLocation(random)));
                        game.ItemInRoom = new BluePotion(game, GetRandomLocation(random));
                        break;
                    }
                case 3:
                    {
                        game.Enemies.Add(new Ghoul(game, GetRandomLocation(random)));
                        game.ItemInRoom = new Bow(game, GetRandomLocation(random));
                        break;
                    }
                case 4:
                    {
                        game.Enemies.Add(new Bat(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghost(game, GetRandomLocation(random)));
                        if (game.CheckPlayerInventory("Bow"))
                        {
                            if (game.CheckPlayerInventory("Blue potion"))
                                return;
                            else
                                game.ItemInRoom = new BluePotion(game, GetRandomLocation(random));
                        }
                        else
                            game.ItemInRoom = new Bow(game, GetRandomLocation(random));
                        break;
                    }
                case 5:
                    {
                        game.Enemies.Add(new Bat(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghoul(game, GetRandomLocation(random)));
                        game.ItemInRoom = new RedPotion(game, GetRandomLocation(random));
                        break;
                    }
                case 6:
                    {
                        game.Enemies.Add(new Ghost(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghoul(game, GetRandomLocation(random)));
                        game.ItemInRoom = new Mace(game, GetRandomLocation(random));
                        break;
                    }
                case 7:
                    {
                        game.Enemies.Add(new Bat(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghost(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghoul(game, GetRandomLocation(random)));
                        if (game.CheckPlayerInventory("Mace"))
                        {
                            if (game.CheckPlayerInventory("Red potion"))
                                return;
                            else
                                game.ItemInRoom = new RedPotion(game, GetRandomLocation(random));
                        }
                        else
                            game.ItemInRoom = new Mace(game, GetRandomLocation(random));
                        break;
                    }
                case 8:
                    {
                        game.Enemies.Add(new Wizard(game, GetRandomLocation(random)));
                        if (game.CheckPlayerInventory("Bow"))
                            game.ItemInRoom = new Quiver(game, GetRandomLocation(random));
                        break;
                    }
                case 9:
                    {
                        game.Enemies.Add(new Ghost(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghoul(game, GetRandomLocation(random)));
                        if (game.CheckPlayerInventory("Bow"))
                            game.ItemInRoom = new Shield(game, GetRandomLocation(random));
                        else
                            game.ItemInRoom = new Bow(game, GetRandomLocation(random));
                        break;
                    }
                case 10:
                    {
                        game.Enemies.Add(new Wizard(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Bat(game, GetRandomLocation(random)));
                        if (game.CheckPlayerInventory("Red potion"))
                            game.ItemInRoom = new BattleAxe(game, GetRandomLocation(random));
                        else
                            game.ItemInRoom = new RedPotion(game, GetRandomLocation(random));
                        break;
                    }
                case 11:
                    {
                        game.Enemies.Add(new Wizard(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghost(game, GetRandomLocation(random)));
                        if (game.CheckPlayerInventory("Battle axe"))
                            return;
                        else
                            game.ItemInRoom = new BattleAxe(game, GetRandomLocation(random));
                        break;
                    }
                case 12:
                    {
                        game.Enemies.Add(new Bat(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghost(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghoul(game, GetRandomLocation(random)));
                        if (game.CheckPlayerInventory("Bow"))
                        {
                            if (game.CheckPlayerInventory("Quiver"))
                                return;
                            else
                                game.ItemInRoom = new Quiver(game, GetRandomLocation(random));
                        }
                        break;
                    }
                case 13:
                    {
                        game.Enemies.Add(new Bat(game, GetRandomLocation(random)));
                        game.ItemInRoom = new Bomb(game, GetRandomLocation(random));
                        break;
                    }
                case 14:
                    {
                        game.Enemies.Add(new Ghoul(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Wizard(game, GetRandomLocation(random)));
                        if (game.CheckPlayerInventory("Blue potion"))
                        {
                            if (game.CheckPlayerInventory("Shield"))
                                return;
                            else
                                game.ItemInRoom = new Shield(game, GetRandomLocation(random));
                        }
                        else
                            game.ItemInRoom = new BluePotion(game, GetRandomLocation(random));
                        break;
                    }
                case 15:
                    {
                        game.Enemies.Add(new Bat(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghost(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Wizard(game, GetRandomLocation(random)));
                        if (game.CheckPlayerInventory("Battle axe"))
                        {
                            if (game.CheckPlayerInventory("Bow"))
                            {
                                if (game.CheckPlayerInventory("Quiver"))
                                    return;
                                else
                                    game.ItemInRoom = new Quiver(game, GetRandomLocation(random));
                            }
                        }
                        else
                            game.ItemInRoom = new BattleAxe(game, GetRandomLocation(random));
                        break;
                    }
                case 16:
                    {
                        game.Enemies.Add(new Ghost(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Wizard(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghoul(game, GetRandomLocation(random)));
                        if (game.CheckPlayerInventory("Bomb"))
                        {
                            if (game.CheckPlayerInventory("Red potion"))
                            {
                                if (game.CheckPlayerInventory("Blue potion"))
                                    return;
                                else
                                    game.ItemInRoom = new BluePotion(game, GetRandomLocation(random));
                            }
                            else
                                game.ItemInRoom = new RedPotion(game, GetRandomLocation(random));
                        }
                        else
                            game.ItemInRoom = new Bomb(game, GetRandomLocation(random));
                        break;
                    }
                case 17:
                    {
                        game.Enemies.Add(new Ghost(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Wizard(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Ghoul(game, GetRandomLocation(random)));
                        game.Enemies.Add(new Bat(game, GetRandomLocation(random)));
                        if (game.CheckPlayerInventory("Shield"))
                        {
                            if (game.CheckPlayerInventory("Bow"))
                            {
                                if (game.CheckPlayerInventory("Quiver"))
                                    return;
                                else
                                    game.ItemInRoom = new Quiver(game, GetRandomLocation(random));
                            }
                        }
                        else
                            game.ItemInRoom = new Shield(game, GetRandomLocation(random));
                        break;
                    }
                case 18:
                    {
                        break;
                    }
            }
        }
    }
}
