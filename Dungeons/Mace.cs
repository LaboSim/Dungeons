using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Dungeons
{
    class Mace : Weapon
    {
        public Mace(Game game, Point location) : base(game, location)
        {

        }

        public override string Name { get { return "Mace"; } }

        public override void Attack(Direction direction, Random random)
        {
            if (direction == Direction.Up)
            {
                if (DamageEnemy(direction, 20, 6, random) == false)
                {
                    if (DamageEnemy(Direction.Right, 20, 6, random) == false)
                    {
                        if (DamageEnemy(Direction.Down, 20, 6, random) == false)
                        {
                            DamageEnemy(Direction.Left, 20, 6, random);
                        }
                    }
                }
            }
            else if(direction == Direction.Right)
            {
                if(DamageEnemy(direction, 20, 6, random) == false)
                {
                    if(DamageEnemy(Direction.Down, 20, 6, random) == false)
                    {
                        if(DamageEnemy(Direction.Left, 20, 6, random) == false)
                        {
                            DamageEnemy(Direction.Up, 20, 6, random);
                        }
                    }
                }
            }
            else if(direction == Direction.Down)
            {
                if(DamageEnemy(direction, 20, 6, random) == false)
                {
                    if(DamageEnemy(Direction.Left, 20, 6, random) == false)
                    {
                        if(DamageEnemy(Direction.Up, 20, 6, random) == false)
                        {
                            DamageEnemy(Direction.Right, 20, 6, random);
                        }
                    }
                }
            }
            else
            {
                if(DamageEnemy(Direction.Left, 20, 6, random) == false)
                {
                    if(DamageEnemy(Direction.Up, 20, 6, random) == false)
                    {
                        if(DamageEnemy(Direction.Right, 20, 6, random) == false)
                        {
                            DamageEnemy(Direction.Down, 20, 6, random);
                        }
                    }
                }
            }
        }
    }
}
