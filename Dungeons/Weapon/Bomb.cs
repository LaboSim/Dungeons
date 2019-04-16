using System;
using System.Drawing;

namespace Dungeons
{
    class Bomb : Weapon, IDisposable
    {
        private const int damage = 5;
        private const int range = 10;

        public Bomb(Game game, Point location) : base(game, location)
        {
            Used = false;
        }

        public override string Name { get { return "Bomb"; } }

        public bool Used { get; private set; }

        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(Direction.Down, range, damage, random);
            DamageEnemy(Direction.Left, range, damage, random);
            DamageEnemy(Direction.Right, range, damage, random);
            DamageEnemy(Direction.Up, range, damage, random);
            Used = true;
        }
    }
}
