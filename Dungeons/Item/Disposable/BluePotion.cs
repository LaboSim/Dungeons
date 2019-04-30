using System;
using System.Drawing;

namespace Dungeons
{
    class BluePotion : Disposable
    {
        private const int additionalHealth = 5;

        public BluePotion(Game game, Point location, Player player) : base(game, location, player)
        {

        }
        public override string Name { get { return "Blue potion"; } }

        public override void Use(Random random)
        {
            player.IncreaseHealth(additionalHealth, random);            
            Use();
        }
    }
}
