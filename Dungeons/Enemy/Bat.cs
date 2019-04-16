using System;
using System.Drawing;

namespace Dungeons
{
    class Bat : Enemy
    {
        private const int minHealth = 1;
        private const int maxDamage = 2;

        public Bat(Game game, Point location) : base(game, location, 6)
        {

        }

        public override void Move(Random random)
        {
            if(HitPoints >= minHealth)
            {
                if(random.Next(1,3) == 1)
                {
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                }
                else
                {
                    location = Move((Direction)random.Next(4), game.Boundaries);
                }
                if (NearPlayer())
                {
                    game.HitPlayer(maxDamage, random);
                }
            }
        }
    }
}
