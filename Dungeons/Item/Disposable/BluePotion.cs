using System;
using System.Drawing;

namespace Dungeons
{
    class BluePotion : Disposable
    {
        private const int additionalHealth = 5;

        public BluePotion(Game game, Point location) : base(game, location)
        {

        }
        public override string Name { get { return "Blue potion"; } }

        public override void Use(Random random)
        {
            game.IncreasePlayerHealth(additionalHealth, random);
            Use();
        }
    }
}
