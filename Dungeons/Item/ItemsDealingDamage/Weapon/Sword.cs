using System;
using System.Drawing;

namespace Dungeons
{
    class Sword : Weapon
    {
        private const int damage = 3;
        private const int range = 8;

        public Sword(Game game, Point location) : base(game, location)
        {

        }

        public override string Name
        {
            get
            {
                return "Sword";
            }
        }

        public override void Attack(Direction direction, Random random)
        {
            if(direction == Direction.Up)
            {
                if(DamageEnemy(direction, range, damage, random) == false)
                {
                    if(DamageEnemy(Direction.Right, range, damage, random) == false)
                    {
                        DamageEnemy(Direction.Left, range, damage, random);
                    }
                }
            }
            else if(direction == Direction.Right)
            {
                if(DamageEnemy(direction, range, damage, random) == false)
                {
                    if(DamageEnemy(Direction.Down, range, damage, random) == false)
                    {
                        DamageEnemy(Direction.Up, range, damage, random);
                    }
                }
            }
            else if(direction == Direction.Down)
            {
                if(DamageEnemy(direction, range, damage, random) == false)
                {
                    if(DamageEnemy(Direction.Left, range, damage, random) == false)
                    {
                        DamageEnemy(Direction.Right, range, damage, random);
                    }
                }
            }
            else
            {
                if(DamageEnemy(direction, range, damage, random) == false)
                {
                    if(DamageEnemy(Direction.Up, range, damage, random) == false)
                    {
                        DamageEnemy(Direction.Down, range, damage, random);
                    }
                }
            }
        }
    }
}
