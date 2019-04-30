using System.Drawing;

namespace Dungeons
{
    abstract class Item
    {
        #region Fields and Properties
        protected Game game;
        protected Point location;

        public Point Location { get { return location; } }
        public bool PickedUp { get; private set; }
        #endregion

        public Item(Game game, Point location)
        {
            this.game = game;
            this.location = location;
            PickedUp = false;
        }

        public void PickUp()
        {
            PickedUp = true;
        }

        public abstract string Name { get; }
    }
}
