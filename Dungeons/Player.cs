using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Dungeons
{
    class Player : Mover
    {
        private const int distanceOfTheWeaponToThePlayer = 1;
        private int numberOfMove = 0;
        public int NumberOfMoves { get { return numberOfMove; } }
        private Weapon equippedWeapon;
        private List<Weapon> inventory = new List<Weapon>();
        public List<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach(Weapon weapon in inventory)
                {
                    names.Add(weapon.Name);
                }
                return names;
            }
        }

        public int HitPoints { get; private set; }

        public Player(Game game, Point location) : base(game, location)
        {
            HitPoints = 10;
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            if (!game.WeaponInRoom.PickedUp)
            {
                if (Nearby(game.WeaponInRoom.Location, distanceOfTheWeaponToThePlayer))
                {
                    game.WeaponInRoom.PickUpWeapon();
                    inventory.Add(game.WeaponInRoom);
                    if (inventory.Count == 1)
                        game.Equip(game.WeaponInRoom.Name);
                }
            }
        }

        public void Attack(Direction direction, Random random)
        {
            if (equippedWeapon != null)
                equippedWeapon.Attack(direction, random);
        }

        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

        public string choosenWeapon()
        {
            if (equippedWeapon != null)
                return equippedWeapon.Name;
            else
                return "";
        }

        public void Equip(string weaponName)
        {
            foreach(Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
            }
        }

        public bool CheckPotionUsed()
        {
            IPotion potion;
            bool potionUsed = true;

            foreach(Weapon weapon in inventory)
            {
                if (equippedWeapon.Name == weapon.Name && weapon is IPotion)
                {
                    potion = weapon as IPotion;
                    potionUsed = potion.Used;
                    DeletePotion(weapon);
                    break;
                }
            }
            return potionUsed;
        }

        private void DeletePotion(Weapon weapon)
        {
            equippedWeapon = null;
            inventory.Remove(weapon);
            Weapons.Remove(weapon.Name);           
        }

        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }
    }
}
