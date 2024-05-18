4. Check yourself
mandatory
Based on 3-modified_behavior, outside of the Player class, create a new class CurrentHPArgs that inherits from EventArgs with the following:

Properties:
currentHp: public float that cannot be modified
Constructor:
Takes a float newHp and sets it as currentHp‘s value
Within the Player class, create a new EventHandler of type CurrentHPArgs called HPCheck.

Create a new private property status of type string. In the constructor, set its default value as <name> is ready to go!

Create a new method CheckStatus.

Prototype: private void CheckStatus(object sender, CurrentHPArgs e)
Depending on the value of currentHp, set the Player’s status to the following and print it:
If the value is equal to maxHp, print:
<name> is in perfect health!
If the value is between ½ of maxHp (inclusive) and maxHp (exclusive), print:
<name> is doing well!
If the value is between ¼ of maxHp (inclusive) and ½ of maxHp (exclusive), print:
<name> isn't doing too great...
If the value is between 0 (exclusive) and ¼ of maxHp (exclusive), print:
<name> needs help!
If the value is 0, print:
<name> is knocked out!
Within the Player constructor, assign CheckStatus to the HPCheck EventHandler so that when HPCheck is called, it triggers CheckStatus.

In ValidateHP(), trigger the HPCheck event and pass hp as the CurrentHPArgs value.

carrie@ubuntu:~/csharp-delegates_events/4-check_yourself$ cat 0-main.cs
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
carrie@ubuntu:~/csharp-delegates_events/4-check_yourself$
carrie@ubuntu:~/csharp-delegates_events/4-check_yourself$ dotnet run
Electric Mouse has 100 / 100 health

Electric Mouse takes 75 damage!
Electric Mouse isn't doing too great...
Electric Mouse has 25 / 100 health

Electric Mouse heals 25 HP!
Electric Mouse is doing well!
Electric Mouse has 50 / 100 health

Electric Mouse takes 50 damage!
Electric Mouse is knocked out!
Electric Mouse has 0 / 100 health
carrie@ubuntu:~/csharp-delegates_events/4-check_yourself$
Repo:

GitHub repository: atlas-csharp
Directory: csharp-delegates_events
File: 4-check_yourself/, 4-check_yourself/4-check_yourself.csproj