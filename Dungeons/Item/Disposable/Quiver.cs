using System;
using System.Drawing;

namespace Dungeons
{
    class Quiver : Disposable
    {
        private const int maxAddtionalArrows = 6;

        public Quiver(Game game, Point location, Player player) : base(game, location, player)
        {
            
        }

        public override string Name { get { return "Quiver"; } }

        public override void Use(Random random)
        {
            player.AddArrows(maxAddtionalArrows, random);
            Use();
        }
    }
}
