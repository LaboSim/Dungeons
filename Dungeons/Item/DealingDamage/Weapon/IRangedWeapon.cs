using System;

namespace Dungeons
{
    interface IRangedWeapon
    {
        int NumberOfArrows { get; }
        void AddArrows(int number, Random random);
    }
}
