using System;

class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem;
    public int durability { get; set; }

    /// <summary>
    /// Constructor for Decoration
    /// </summary>
    /// <param name="name">Name of the Decoration (default: "Decoration").</param>
    /// <param name="durability">Objects durability (HP) (default: 1).</param>
    /// <param name="isQuestItem">Flag if it's a Quest item (default: false).</param>
    public Decoration(
        string name = "Decoration",
        int durability = 1,
        bool isQuestItem = false
    )
    {
        if (durability <= 0)
            throw new System.Exception("Durability must be greater than 0");

        this.isQuestItem = isQuestItem;
        this.name = name;
        this.durability = durability;
    }

    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine("The {0} has been broken.", name);
            return;
        }

        if (isQuestItem)
            Console.WriteLine("You look at the {0}. There's a key inside.", name);
        else
            Console.WriteLine("You look at the {0}. Not much to see here.", name);
    }

    public void Break()
    {
        durability -= 1;

        if (this.durability > 0)
            Console.WriteLine("You hit the {0}. It cracks.", name);
        else if (this.durability == 0)
            Console.WriteLine("You smash the {0}. What a mess.", name);
        else
            Console.WriteLine("The {0} is already broken.", name);
    }
}
