using System.Drawing;

namespace Dungeons
{
    abstract class Item
    {
        protected Game game;
        protected Point location;
        public Point Location { get { return location; } }
        public bool PickedUp { get; private set; }

        public Item(Game game, Point location)
        {
            this.game = game;
            this.location = location;
            PickedUp = false;
        }

        public void PickUpItem()
        {
            PickedUp = true;
        }

        public abstract string Name { get; }
    }
}
