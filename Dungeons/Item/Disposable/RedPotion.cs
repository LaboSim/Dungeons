using System;
using System.Drawing;

namespace Dungeons
{
    class RedPotion : Disposable
    {
        private const int additionalHealth = 10;

        public RedPotion(Game game, Point location, Player player) : base(game, location, player)
        {

        }
        public override string Name { get { return "Red potion"; } }

        public override void Use(Random random)
        {
            player.IncreaseHealth(additionalHealth, random);            
            Use();
        }
    }
}
