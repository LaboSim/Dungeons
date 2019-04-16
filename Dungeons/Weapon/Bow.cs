using System;
using System.Drawing;

namespace Dungeons
{
    class Bow : Weapon
    {
        private const int damage = 1;
        private const int range = 18;

        public Bow(Game game, Point location) : base(game, location)
        {

        }

        public override string Name { get { return "Bow"; } }

        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(direction, range, damage, random);
        }
    }
}
