using System;
using System.Drawing;

namespace Dungeons
{
    class RedPotion : Weapon, IDisposable
    {
        private const int additionalHealth = 10;

        public RedPotion(Game game, Point location) : base(game, location)
        {
            Used = false;
        }

        public bool Used { get; private set; }

        public override string Name { get { return "Red potion"; } }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(additionalHealth, random);
            Used = true;
        }
    }
}
