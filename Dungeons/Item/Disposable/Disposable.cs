using System;
using System.Drawing;

namespace Dungeons
{
    abstract class Disposable : Item
    {
        protected Player player;
        public bool Used { get; private set; }

        public Disposable(Game game, Point location, Player player) : base(game, location)
        {
            this.player = player;
            Used = false;
        }

        public void Use()
        {
            Used = true;
        }

        public abstract void Use(Random random);      
    }
}
