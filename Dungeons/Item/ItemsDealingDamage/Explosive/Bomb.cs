using System;
using System.Drawing;

namespace Dungeons
{
    class Bomb : Explosive
    {
        private const int damage = 5;
        private const int range = 10;

        public Bomb(Game game, Point location) : base(game, location)
        {

        }

        public override string Name { get { return "Bomb"; } }

        public override void Detonate(Random random)
        {
            DamageEnemy(Direction.Up, range, damage, random);
            DamageEnemy(Direction.Right, range, damage, random);
            DamageEnemy(Direction.Down, range, damage, random);
            DamageEnemy(Direction.Left, range, damage, random);
            BlowUp();
        }
    }
}
