using System;
using System.Drawing;

namespace Dungeons
{
    class BattleAxe : Weapon
    {
        private const int damage = 8;
        private const int range = 5;

        public BattleAxe(Game game, Point location) : base(game, location)
        {

        }

        public override string Name { get { return "Battle axe"; } }

        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(direction, range, damage, random);
        }
    }
}
