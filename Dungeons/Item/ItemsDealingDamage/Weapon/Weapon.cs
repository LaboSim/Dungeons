using System;
using System.Drawing;

namespace Dungeons
{
    abstract class Weapon : HandlingEnemyDamage
    {       
        public Weapon(Game game, Point location) : base(game, location)
        {
          
        }

        public abstract void Attack(Direction direction, Random random);
    }
}
