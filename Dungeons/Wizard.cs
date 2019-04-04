using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Dungeons
{
    class Wizard : Enemy
    {
        public Wizard(Game game, Point location) : (game, location, 20)
        {
                
        }

        public override void Move(Random random)
        {
            throw new NotImplementedException();
        }
    }
}
