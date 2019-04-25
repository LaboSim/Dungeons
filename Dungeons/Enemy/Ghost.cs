using System;
using System.Drawing;

namespace Dungeons
{
    class Ghost : Enemy
    {
        private const int minHealth = 1;
        private const int maxDamage = 3;
        private const int hitPointsOfLifeAtTheBeginning = 8;

        public Ghost(Game game, Point location) : base(game, location, hitPointsOfLifeAtTheBeginning)
        {

        }

        public override void Move(Random random)
        {
            if(HitPoints >= minHealth)
            {
                if(random.Next(1,4) == 1)
                {
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                }
                if (NearPlayer())
                {
                    game.HitPlayer(maxDamage, random);
                }
            }
        }
    }
}
