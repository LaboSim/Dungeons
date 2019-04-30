using System;
using System.Drawing;

namespace Dungeons
{
    abstract class Explosive : DamageForEnemy
    {
        public bool Blow { get; private set; }

        public Explosive(Game game, Point location) : base(game, location)
        {
            Blow = false;  
        }

        public void BlowUp()
        {
            Blow = true;
        }

        public abstract void Detonate(Random random);
    }
}
