using System;

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Interact()
    {
        // Implementation not required for this task
    }

    public void Break()
    {
        // Implementation not required for this task
    }

    public void Collect()
    {
        // Implementation not required for this task
    }
}
