using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons
{
    static class PlayerStatistics
    {
        private static int movePlayer;
        private static int attackPlayer;
        private static int successfulAttackPlayer;

        public static void StatisticsMove(Player player, int moves)
        {
            movePlayer = moves;
        }

        public static void StatisticsAttack(Player player, int attack)
        {
            attackPlayer = attack;
        }

        public static void StatisticsSuccessfulAttack(Enemy enemy, int successfulAttack)
        {
            successfulAttackPlayer = successfulAttack;
        }

        public static int ShowNumberOfMoves()
        {
            return movePlayer;
        }

        public static int ShowNumberOfAttack()
        {
            return attackPlayer;
        }

        public static int ShowNumberOfSuccessfulAttack()
        {
            return successfulAttackPlayer;
        }
    }
}
