using System;
using System.Drawing;

namespace Dungeons
{
    class Ghoul : Enemy
    {
        #region Constant fields
        private const int minHealth = 1;
        private const int maxDamage = 4;
        private const int startingHitPoints = 10;
        #endregion

        public Ghoul(Game game, Point location) : base(game, location, startingHitPoints)
        {

        }

        public override void Move(Random random)
        {
            if(HitPoints >= minHealth)
            {
                if(random.Next(1,4) == 1 || random.Next(1,4) == 2)
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
