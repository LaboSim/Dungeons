using System;
using System.Drawing;

namespace Dungeons
{
    abstract class Disposable : Item
    {
        public bool Used { get; private set; }

        public Disposable(Game game, Point location) : base(game, location)
        {
            Used = false;
        }

        public void UseDisposable()
        {
            Used = true;
        }

        public abstract void Use(Random random);      
    }
}
