using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Dungeons
{
    abstract class Armour : Item
    {
        public int PointsOfArmour { get; set; }

        public Armour(Game game, Point location, int pointsOfArmour) : base(game, location)
        {
            this.PointsOfArmour = pointsOfArmour;          
        }

        public abstract int GetDamage(int receivedDamage);
    }
}
