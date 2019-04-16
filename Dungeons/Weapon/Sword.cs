using System;
using System.Drawing;

namespace Dungeons
{
    class Sword : Weapon
    {
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
                if(DamageEnemy(direction, 8, 3, random) == false)
                {
                    if(DamageEnemy(Direction.Right, 8, 3, random) == false)
                    {
                        DamageEnemy(Direction.Left, 8, 3, random);
                    }
                }
            }
            else if(direction == Direction.Right)
            {
                if(DamageEnemy(direction, 8, 3, random) == false)
                {
                    if(DamageEnemy(Direction.Down, 8, 3, random) == false)
                    {
                        DamageEnemy(Direction.Up, 8, 3, random);
                    }
                }
            }
            else if(direction == Direction.Down)
            {
                if(DamageEnemy(direction, 8, 3, random) == false)
                {
                    if(DamageEnemy(Direction.Left, 8, 3, random) == false)
                    {
                        DamageEnemy(Direction.Right, 8, 3, random);
                    }
                }
            }
            else
            {
                if(DamageEnemy(direction, 8, 3, random) == false)
                {
                    if(DamageEnemy(Direction.Up, 8, 3, random) == false)
                    {
                        DamageEnemy(Direction.Down, 8, 3, random);
                    }
                }
            }
        }
    }
}
