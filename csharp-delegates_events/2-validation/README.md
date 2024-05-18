2. Validation
mandatory
Based on 1-damage_delegation, inside the TakeDamage() and HealDamage() methods, calculate the new value of the Player’s hp but do not set the value of hp in these methods.

If damage is taken, subtract damage from hp
If health is healed, add heal to hp
Create a new method ValidateHP() that sets the new value of the Player’s hp:

Prototype: public void ValidateHP(float newHp)
If newHp is negative, set hp to 0
If newHp is larger than maxHp, set hp to the value of maxHp
Otherwise, set hp to the value of newHp
In the TakeDamage() and HealDamage() methods, add a call to ValidateHP() and pass in the value calculated within that method.

carrie@ubuntu:~/csharp-delegates_events/2-validation$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Electric Mouse");

        player.PrintHealth();

        player.TakeDamage(50f);

        player.PrintHealth();

        player.HealDamage(49f);

        player.PrintHealth();
    }
}
carrie@ubuntu:~/csharp-delegates_events/2-validation$
carrie@ubuntu:~/csharp-delegates_events/2-validation$ dotnet run
Electric Mouse has 100 / 100 health
Electric Mouse takes 50 damage!
Electric Mouse has 50 / 100 health
Electric Mouse heals 49 HP!
Electric Mouse has 99 / 100 health
carrie@ubuntu:~/csharp-delegates_events/2-validation$ 
Repo:

GitHub repository: atlas-csharp
Directory: csharp-delegates_events
File: 2-validation/, 2-validation/2-validation.csproj