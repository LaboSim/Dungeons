using System;
using System.Drawing;

namespace Dungeons
{
    class RedPotion : Disposable
    {
        private const int additionalHealth = 10;

        public RedPotion(Game game, Point location) : base(game, location)
        {

        }
        public override string Name { get { return "Red potion"; } }

        public override void Use(Random random)
        {
            game.IncreasePlayerHealth(additionalHealth, random);
            Use();
        }
    }
}
