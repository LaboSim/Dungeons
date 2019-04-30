using System;
using System.Drawing;

namespace Dungeons
{
    class Bow : Weapon, IRangedWeapon
    {
        private const int damage = 1;
        private const int range = 18;
        private const int startingNumberOfArrows = 3;

        public int NumberOfArrows { get; private set; }

        public Bow(Game game, Point location) : base(game, location)
        {
            NumberOfArrows = startingNumberOfArrows;
            game.NumberOfArrows = NumberOfArrows;
        }

        public override string Name { get { return "Bow"; } }

        public override void Attack(Direction direction, Random random)
        {
            NumberOfArrows--;
            game.NumberOfArrows = NumberOfArrows;           
            DamageEnemy(direction, range, damage, random);
            if (NumberOfArrows <= 0)
                game.DeactivateArch();
        }

        public void AddArrows(int number, Random random)
        {
            NumberOfArrows += random.Next(1, number);
            game.NumberOfArrows = NumberOfArrows;
        }
    }
}
