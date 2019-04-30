using System;
using System.Collections.Generic;
using System.Drawing;

namespace Dungeons
{
    class Player : Movement
    {
        /// <summary>
        /// Class to handle with movement, attack, equipment of player
        /// </summary>
        #region Fields and Properties
        private const int distanceOfTheItemToThePlayer = 1;

        private Item equippedItem;

        public int HitPoints { get; private set; }
        #endregion

        private List<Item> inventory = new List<Item>();
        public List<string> Items
        {
            get
            {
                List<string> names = new List<string>();
                foreach(Item item in inventory)
                {
                    names.Add(item.Name);
                }
                return names;
            }
        }       

        public Player(Game game, Point location) : base(game, location)
        {
            HitPoints = 10;
        }

        #region Player's activities
        public void Move(Direction direction)
        {
            PlayerStatistics.MovePlayer++;
            base.location = Move(direction, game.Boundaries);
            if (!game.ItemInRoom.PickedUp)
            {
                if (Nearby(game.ItemInRoom.Location, distanceOfTheItemToThePlayer))
                {                        
                    game.ItemInRoom.PickUp();
                    inventory.Add(game.ItemInRoom);
                    if (inventory.Count == 1)
                        game.Equip(game.ItemInRoom.Name);
                }
            }
        }

        public void Attack(Direction direction, Random random)
        {
            Weapon weapon;
            weapon = equippedItem as Weapon;
            if (equippedItem != null)
            {
                weapon.Attack(direction, random);
                PlayerStatistics.AttackPlayer++;
            }                
        }
        #endregion

        #region Equipment activities
        public void DeactivateItem()
        {
            equippedItem = null;
        }

        public void DestroyArmour()
        {
            OneOffItem(equippedItem);
        }

        public string ChoosenItem()
        {
            if (equippedItem != null)
                return equippedItem.Name;
            else
                return "";
        }

        public void Equip(string itemName)
        {
            foreach (Item item in inventory)
            {
                if (item.Name == itemName)
                {
                    equippedItem = item;
                    break;
                }
            }
        }
        #endregion

        #region Disposable activities
        public bool UseDisposable(Random random)
        {
            Disposable disposable;
            bool used = false;

            if (equippedItem != null)
            {
                disposable = equippedItem as Disposable;
                foreach (Item item in inventory)
                {
                    if (disposable.Name == item.Name)
                    {
                        disposable.Use(random);
                        used = disposable.Used;
                        OneOffItem(item);
                        break;
                    }
                }
            }
            return used;
        }

        public bool DetonateBomb(Random random)
        {
            Explosive explosive;
            bool used = false;

            if (equippedItem != null)
            {
                explosive = equippedItem as Explosive;
                PlayerStatistics.AttackPlayer++;

                foreach (Item item in inventory)
                {
                    if (explosive.Name == item.Name)
                    {
                        explosive.Detonate(random);
                        used = explosive.Blow;
                        OneOffItem(item);
                        break;
                    }
                }
            }
            return used;
        }

        private void OneOffItem(Item item)
        {
            equippedItem = null;
            inventory.Remove(item);
            Items.Remove(item.Name);
        }

        public void AddArrows(int arrows, Random random)
        {
            foreach (Item item in inventory)
            {
                IRangedWeapon arch;
                if (item is IRangedWeapon)
                {
                    arch = item as IRangedWeapon;
                    arch.AddArrows(arrows, random);
                    break;
                }
            }
        }
        #endregion

        #region Activities regarding to hit points of player
        public void Hit(int maxDamage, Random random)
        {
            int receivedDamage = random.Next(1, maxDamage);
            if (equippedItem != null && equippedItem is Armour)
            {
                Armour armour = equippedItem as Armour;
                int damage;
                damage = armour.GetDamage(receivedDamage);
                if (damage > 0)
                    return;
                else
                    HitPoints -= damage;
            }
            else
                HitPoints -= receivedDamage;
        }

        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }
        #endregion        
    }
}
