3. Modified behavior
mandatory
Based on 2-validation, outside of the Player class, create an enum Modifier with the values Weak, Base, Strong.

Outside of the Player class, create a delegate CalculateModifier:

Prototype: public delegate float CalculateModifier(float baseValue, Modifier modifier)
Create a method ApplyModifier that follows the prototype of CalculateModifier.

If modifier is Weak, return half of the base value
If modifier is Base, return the base value
If modifier is Strong, return 1.5 times the base value
carrie@ubuntu:~/csharp-delegates_events/3-modified_behavior$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Electric Mouse");
        CalculateModifier mod = new CalculateModifier(player.ApplyModifier);

        player.PrintHealth();

        player.TakeDamage(mod(50f, Modifier.Weak));

        player.PrintHealth();

        player.HealDamage(mod(10f, Modifier.Strong));

        player.PrintHealth();
    }
}
carrie@ubuntu:~/csharp-delegates_events/3-modified_behavior$
carrie@ubuntu:~/csharp-delegates_events/3-modified_behavior$ dotnet run
Electric Mouse has 100 / 100 health
Electric Mouse takes 25 damage!
Electric Mouse has 75 / 100 health
Electric Mouse heals 15 HP!
Electric Mouse has 90 / 100 health
carrie@ubuntu:~/csharp-delegates_events/3-modified_behavior$
Repo:

GitHub repository: atlas-csharp
Directory: csharp-delegates_events
File: 3-modified_behavior/, 3-modified_behavior/3-modified_behavior.csproj