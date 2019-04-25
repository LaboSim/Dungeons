using System;
using System.Drawing;

namespace Dungeons
{
    class Quiver : Disposable
    {
        private const int maxAddtionalArrows = 6;

        public Quiver(Game game, Point location) : base(game, location)
        {
            
        }

        public override string Name { get { return "Quiver"; } }

        public override void Use(Random random)
        {
            game.AddArrows(maxAddtionalArrows, random);
            UseDisposable();
        }
    }
}
