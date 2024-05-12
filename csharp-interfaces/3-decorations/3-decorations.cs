using System;

namespace csharp-interfaces
{
    /// <summary>
    /// A decoration that can be interacted with and broken.
    /// </summary>
    public class Decoration : Base, IInteractive, IBreakable
    {
        /// <summary>
        /// Gets or sets a value indicating whether this decoration is a quest item.
        /// </summary>
        public bool isQuestItem { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Decoration"/> class.
        /// </summary>
        /// <param name="name">The name of the decoration.</param>
        /// <param name="durability">The durability of the decoration.</param>
        public Decoration(string name = "Decoration", int durability = 1)
        {
            if (durability <= 0)
            {
                throw new Exception("Durability must be greater than 0");
            }

            this.name = name;
            this.durability = durability;
            this.isQuestItem = false;
        }

        /// <summary>
        /// Interacts with the decoration.
        /// </summary>
        public void Interact()
        {
            if (durability <= 0)
            {
                Console.WriteLine($"The {name} has been broken.");
                return;
            }

            if (isQuestItem)
            {
                Console.WriteLine($"You look at the {name}. There's a key inside.");
            }
            else
            {
                Console.WriteLine($"You look at the {name}. Not much to see here.");
            }
        }

        /// <summary>
        /// Breaks the decoration.
        /// </summary>
        public void Break()
        {
            if (durability > 0)
            {
                Console.WriteLine($"You hit the {name}. It cracks.");
            }

            if (durability == 0)
            {
                Console.WriteLine($"You smash the {name}. What a mess.");
            }

            if (durability < 0)
            {
                Console.WriteLine($"The {name} is already broken.");
            }

            durability--;
        }
    }
}
