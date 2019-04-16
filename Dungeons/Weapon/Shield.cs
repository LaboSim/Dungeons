using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Dungeons
{
    class Shield : Weapon
    {
        int armour;

        public Shield(Game game, Point location, int armour) : base(game, location)
        {
            this.armour = armour;
        }

        public override string Name { get { return "Shield"; } }

        public override void Attack(Direction direction, Random random)
        {
            game.ActivatePlayerShield(armour);
        }
    }
}
