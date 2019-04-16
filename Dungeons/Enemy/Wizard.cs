using System;
using System.Drawing;

namespace Dungeons
{
    class Wizard : Enemy
    {
        public Wizard(Game game, Point location) : base(game, location, 20)
        {
                
        }

        public override void Move(Random random)
        {
            if(HitPoints >= 1)
            {
                if(random.Next(1,6) == 1)
                {
                    location = Move((Direction)random.Next(4), game.Boundaries);
                }
                else
                {
                    location = Move(FindPlayerDirection(game.PlayerLocation),game.Boundaries);
                }
                if (NearPlayer())
                {
                    game.HitPlayer(5, random);
                }
            }
        }
    }
}
