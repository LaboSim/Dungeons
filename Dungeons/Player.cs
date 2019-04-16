using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Dungeons
{
    class Player : Movement
    {
        private const int distanceOfTheWeaponToThePlayer = 1;

        private int numberOfMoves = 0;
        public int NumberOfMoves { get { return numberOfMoves; } }

        private int numberOfAttack = 0;
        public int NumberOfAttack { get { return numberOfAttack; } }

        public int NumberOfArrows { get; private set; }

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
        public int CheckArmour { get; private set; }

        public Player(Game game, Point location) : base(game, location)
        {
            HitPoints = 10;
        }

        public void Move(Direction direction)
        {
            numberOfMoves++;
            base.location = Move(direction, game.Boundaries);
            if (!game.WeaponInRoom.PickedUp)
            {
                if (Nearby(game.WeaponInRoom.Location, distanceOfTheWeaponToThePlayer))
                {
                    if (game.WeaponInRoom.Name == "Bow")
                        NumberOfArrows += 3;
                    else if (game.WeaponInRoom.Name == "Shield")
                        CheckArmour = 5;
                        
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
            {
                equippedWeapon.Attack(direction, random);
                if (equippedWeapon.Name == "Bow")
                {
                    NumberOfArrows--;
                    checkNumberOfArrows();
                }
                if (equippedWeapon != null)
                {
                    if (equippedWeapon.Name != "Shield" && equippedWeapon.Name != "Blue potion" &&
                    equippedWeapon.Name != "Red potion" && equippedWeapon.Name != "Quiver")
                        numberOfAttack++;
                }
            }                
        }

        private void checkNumberOfArrows()
        {
            if (NumberOfArrows == 0)
                equippedWeapon = null;
        }

        public void Hit(int maxDamage, Random random)
        {
            int bufforDamage = 0;
            int receivedDamage = random.Next(1, maxDamage);
            if (equippedWeapon != null && equippedWeapon is Shield)
                damageToShield(receivedDamage, bufforDamage);                
            else
                HitPoints -= receivedDamage;
        }

        private void damageToShield(int receivedDamage, int bufforDamage)
        {
            if (CheckArmour >= 1)
            {
                bufforDamage = CheckArmour - receivedDamage;
                if (bufforDamage > 0)
                    CheckArmour -= receivedDamage;
                else
                {
                    bufforDamage *= -1;
                    HitPoints -= bufforDamage;
                    OneOffItem(equippedWeapon);
                    game.DestroyShield();
                }
            }
        }

        public void ActivateShield(int armour, bool shieldUsed)
        {
            if(shieldUsed == false)
                CheckArmour = armour;
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

        public bool CheckUsedDisposable()
        {
            IDisposable disposable;
            bool used = true;

            foreach(Weapon weapon in inventory)
            {
                if (equippedWeapon.Name == weapon.Name && weapon is IDisposable)
                {
                    disposable = weapon as IDisposable;
                    used = disposable.Used;
                    OneOffItem(weapon);
                    break;
                }
            }
            return used;
        }

        private void OneOffItem(Weapon weapon)
        {
            equippedWeapon = null;
            inventory.Remove(weapon);
            Weapons.Remove(weapon.Name);           
        }

        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }

        public void IncreaseNumberOfArrows(int number, Random random)
        {
            NumberOfArrows += random.Next(1, number);
        }
    }
}
