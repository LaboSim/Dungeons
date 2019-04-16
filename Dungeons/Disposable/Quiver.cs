using System;
using System.Drawing;

namespace Dungeons
{
    class Quiver : Weapon, IDisposable
    {
        public Quiver(Game game, Point location) : base(game, location)
        {
            Used = false;
        }

        public bool Used { get; private set; }

        public override string Name { get { return "Quiver"; } }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerNumberOfArrows(6, random);
            Used = true;
        }
    }
}
