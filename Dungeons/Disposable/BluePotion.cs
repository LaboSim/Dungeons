using System;
using System.Drawing;

namespace Dungeons
{
    class BluePotion : Weapon, IDisposable
    {
        public BluePotion(Game game, Point location) : base(game, location)
        {
            Used = false;
        }

        public bool Used { get; private set; }

        public override string Name { get { return "Blue potion"; } }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(5, random);
            Used = true;
        }
    }
}
