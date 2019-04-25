using System;

namespace Dungeons
{
    interface IHandlingArch
    {
        int NumberOfArrows { get; }
        void AddArrows(int number, Random random);
    }
}
