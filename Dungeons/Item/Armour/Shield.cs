using System.Drawing;

namespace Dungeons
{
    class Shield : Armour
    {
        private const int pointOfDurability = 5;

        public Shield(Game game, Point location, Player player) : base(game, location, player, pointOfDurability)
        {
            game.PointsOfArmour = PointsOfDurability;
        }

        public override string Name { get { return "Shield"; } }

        public override int GetDamage(int receivedDamage)
        {
            PointsOfDurability -= receivedDamage;
            if (PointsOfDurability > 0)
            {
                game.PointsOfArmour = PointsOfDurability;
                return PointsOfDurability;
            }              
            else
            {
                int damage = (-1) * PointsOfDurability;
                player.DestroyArmour();
                return damage;
            }
        }
    }
}
