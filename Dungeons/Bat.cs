using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Dungeons
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location) : base(game, location, 6)
        {

        }

        public override void Move(Random random)
        {
            if(HitPoints >= 1)
            {
                if(random.Next(1,3) == 1)
                {
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                }
                else
                {
                    location = Move((Direction)random.Next(4), game.Boundaries);
                }
            }
        }
    }
}
