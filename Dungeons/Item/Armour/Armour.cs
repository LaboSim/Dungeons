using System.Drawing;

namespace Dungeons
{
    abstract class Armour : Item
    {
        protected Player player;
        public int PointsOfDurability { get; set; }

        public Armour(Game game, Point location, Player player, int pointsOfArmour) : base(game, location)
        {
            this.player = player;
            this.PointsOfDurability = pointsOfArmour;          
        }

        public abstract int GetDamage(int receivedDamage);
    }
}
