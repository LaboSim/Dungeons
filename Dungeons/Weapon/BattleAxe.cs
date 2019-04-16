using System;
using System.Drawing;

namespace Dungeons
{
    class BattleAxe : Weapon
    {
        public BattleAxe(Game game, Point location) : base(game, location)
        {

        }

        public override string Name { get { return "Battle axe"; } }

        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(direction, 5, 8, random);
        }
    }
}
