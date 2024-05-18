5. Eventful
mandatory
Based on 4-check_yourself, create a new method HPValueWarning inside the Player class:

Prototype: private void HPValueWarning(object sender, CurrentHPArgs e)
If the value of e‘s currentHp is 0, print Health has reached zero!
Otherwise, print Health is low!
Optionally, change the colors of the console font or background when the warnings are printed:

Create a method called OnCheckStatus() that takes an object of CurrentHPArgs as a parameter and returns nothing. This method should check if e’s currentHp is less than ¼ of maxHp. If it is, assign HPValueWarning to the HPCheck EventHandler.

Within OnCheckStatus(), call HPCheck with the Player object and e.

Replace the call to HPCheck() in ValidateHP() with a call to OnCheckStatus().

carrie@ubuntu:~/csharp-delegates_events/5-eventful$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Electric Mouse");
        CalculateModifier mod = new CalculateModifier(player.ApplyModifier);

        player.PrintHealth();
        Console.WriteLine();

        player.TakeDamage(mod(75f, Modifier.Base));
        player.PrintHealth();
        Console.WriteLine();

        player.HealDamage(mod(25f, Modifier.Base));
        player.PrintHealth();
        Console.WriteLine();

        player.TakeDamage(mod(50f, Modifier.Base));
        player.PrintHealth();
    }
}
carrie@ubuntu:~/csharp-delegates_events/5-eventful$
carrie@ubuntu:~/csharp-delegates_events/5-eventful$ dotnet run
Electric Mouse has 100 / 100 health

Electric Mouse takes 75 damage!
Electric Mouse isn't doing too great...
Health is low!
Electric Mouse has 25 / 100 health

Electric Mouse heals 25 HP!
Electric Mouse is doing well!
Electric Mouse has 50 / 100 health

Electric Mouse takes 50 damage!
Electric Mouse is knocked out!
Health has reached zero!
Electric Mouse has 0 / 100 health
carrie@ubuntu:~/csharp-delegates_events/5-eventful$
Repo:

GitHub repository: atlas-csharp
Directory: csharp-delegates_events
File: 5-eventful/, 5-eventful/5-eventful.csproj