using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Dungeons
{
    class Bomb : Weapon, IDisposable
    {
        public Bomb(Game game, Point location) : base(game, location)
        {
            Used = false;
        }

        public override string Name { get { return "Bomb"; } }

        public bool Used { get; private set; }

        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(Direction.Down, 10, 5, random);
            DamageEnemy(Direction.Left, 10, 5, random);
            DamageEnemy(Direction.Right, 10, 5, random);
            DamageEnemy(Direction.Up, 10, 5, random);
            Used = true;
        }
    }
}
