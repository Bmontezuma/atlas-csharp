namespace Claptrap
{
    /// <summary>
    /// Base class for objects to inherit.
    /// </summary>
    public abstract class Base
    {
        /// <summary>
        /// Public name of the object.
        /// </summary>
        public string name;

        /// <summary>
        /// Returns a message.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return string.Format("{0} is a {1}", name, this.GetType().Name);
        }
    }

    /// <summary>
    /// Makes an object interactable.
    /// </summary>
    interface IInteractive
    {
        void Interact();
    }

    /// <summary>
    /// Gives objects a durability property and breakable state.
    /// </summary>
    interface IBreakable
    {
        int durability { get; set; }
        void Break();
    }

    /// <summary>
    /// Makes an object collectible.
    /// </summary>
    interface ICollectable
    {
        bool isCollected { get; set; }
        void Collect();
    }

    /// <summary>
    /// Represents a test object inheriting from Base and implementing interfaces.
    /// </summary>
    class TestObject : Base, IInteractive, IBreakable, ICollectable
    {
        public int durability { get; set; }
        public bool isCollected { get; set; }

        public void Interact()
        {
            // Implementation of interaction behavior.
        }

        public void Break()
        {
            // Implementation of break behavior.
        }

        public void Collect()
        {
            // Implementation of collect behavior.
        }
    }
}
