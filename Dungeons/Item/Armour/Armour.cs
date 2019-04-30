using System.Drawing;

namespace Dungeons
{
    abstract class Armour : Item
    {
        public int PointsOfDurability { get; set; }

        public Armour(Game game, Point location, int pointsOfArmour) : base(game, location)
        {
            this.PointsOfDurability = pointsOfArmour;          
        }

        public abstract int GetDamage(int receivedDamage);
    }
}
