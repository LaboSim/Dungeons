using System;
using System.Drawing;

namespace Dungeons
{
    class Mace : Weapon
    {
        private const int damage = 6;
        private const int range = 10;

        public Mace(Game game, Point location) : base(game, location)
        {

        }

        public override string Name { get { return "Mace"; } }

        public override void Attack(Direction direction, Random random)
        {
            if (direction == Direction.Up)
            {
                if (DamageEnemy(direction, range, damage, random) == false)
                {
                    if (DamageEnemy(Direction.Right, range, damage, random) == false)
                    {
                        if (DamageEnemy(Direction.Down, range, damage, random) == false)
                        {
                            DamageEnemy(Direction.Left, range, damage, random);
                        }
                    }
                }
            }
            else if(direction == Direction.Right)
            {
                if(DamageEnemy(direction, range, damage, random) == false)
                {
                    if(DamageEnemy(Direction.Down, range, damage, random) == false)
                    {
                        if(DamageEnemy(Direction.Left, range, damage, random) == false)
                        {
                            DamageEnemy(Direction.Up, range, damage, random);
                        }
                    }
                }
            }
            else if(direction == Direction.Down)
            {
                if(DamageEnemy(direction, range, damage, random) == false)
                {
                    if(DamageEnemy(Direction.Left, range, damage, random) == false)
                    {
                        if(DamageEnemy(Direction.Up, range, damage, random) == false)
                        {
                            DamageEnemy(Direction.Right, range, damage, random);
                        }
                    }
                }
            }
            else
            {
                if(DamageEnemy(Direction.Left, 10, 6, random) == false)
                {
                    if(DamageEnemy(Direction.Up, 10, 6, random) == false)
                    {
                        if(DamageEnemy(Direction.Right, 10, 6, random) == false)
                        {
                            DamageEnemy(Direction.Down, 10, 6, random);
                        }
                    }
                }
            }
        }
    }
}
