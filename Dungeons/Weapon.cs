using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Dungeons
{
    abstract class Weapon : Mover
    {
        public bool PickedUp { get; private set; }

        public Weapon(Game game, Point location) : base(game, location)
        {
            PickedUp = false;
        }

        public void PickUpWeapon()
        {
            PickedUp = true;
        }

        public abstract string Name { get; }
    }
}
