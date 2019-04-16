using System;
using System.Drawing;

namespace Dungeons
{
    class Quiver : Weapon, IDisposable
    {
        private const int addtionalArrows = 6;

        public Quiver(Game game, Point location) : base(game, location)
        {
            Used = false;
        }

        public bool Used { get; private set; }

        public override string Name { get { return "Quiver"; } }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerNumberOfArrows(addtionalArrows, random);
            Used = true;
        }
    }
}
