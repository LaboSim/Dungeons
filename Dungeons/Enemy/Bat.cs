using System;
using System.Drawing;

namespace Dungeons
{
    class Bat : Enemy
    {
        #region Constant fields
        private const int minHealth = 1;
        private const int maxDamage = 2;
        private const int startingHitPoints = 6;
        #endregion

        public Bat(Game game, Point location) : base(game, location, startingHitPoints)
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
