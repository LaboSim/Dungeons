using System;
using System.Drawing;

namespace Dungeons
{
    class Shield : Armour
    {
        private const int pointOfShield = 5;

        public Shield(Game game, Point location) : base(game, location, pointOfShield)
        {
            game.PointsOfArmour = PointsOfArmour;
        }

        public override string Name { get { return "Shield"; } }

        public override int GetDamage(int receivedDamage)
        {
            PointsOfArmour -= receivedDamage;
            if (PointsOfArmour > 0)
            {
                game.PointsOfArmour = PointsOfArmour;
                return PointsOfArmour;
            }              
            else
            {
                int damage = (-1) * PointsOfArmour;
                game.DestroyArmour();
                return damage;
            }
        }
    }
}
