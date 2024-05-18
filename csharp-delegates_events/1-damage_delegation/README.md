1. Damage delegation
mandatory
Based on 0-universal_health, create a delegate CalculateHealth that takes a float amount. Write two methods that follow the prototype of the CalculateHealth delegate:

public void TakeDamage(float damage)

Prints <name> takes <damage> damage!
If damage is negative, the Player takes 0 damage and prints <name> takes 0 damage!
public void HealDamage(float heal)

Prints <name> heals <heal> HP!
If heal is negative, the Player heals 0 HP and prints <name> heals 0 HP!
carrie@ubuntu:~/csharp-delegates_events/1-delegate_delegation$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Electric Mouse");

        player.TakeDamage(25f);

        player.HealDamage(10f);

        player.TakeDamage(-25f);
    }
}
carrie@ubuntu:~/csharp-delegates_events/1-delegate_delegation$
carrie@ubuntu:~/csharp-delegates_events/1-delegate_delegation$ dotnet run
Electric Mouse takes 25 damage!
Electric Mouse heals 10 HP!
Electric Mouse takes 0 damage!
carrie@ubuntu:~/csharp-delegates_events/1-delegate_delegation$
Repo:

GitHub repository: atlas-csharp
Directory: csharp-delegates_events
File: 1-damage_delegation/, 1-damage_delegation/1-damage_delegation.csproj