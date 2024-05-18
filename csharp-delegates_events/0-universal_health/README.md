0. Universal health
mandatory
Create a public class called Player with the following:

Properties:
name: string
maxHp: float
hp: float
You should not be able to change or access the Player’s properties directly from the main file.
Constructor:
Prototype: public Player(string name, float maxHp)
Assign parameters to properties accordingly
Default name: Player
Default maxHp: 100f
maxHp must be greater than 0, otherwise, set maxHp to the default value of 100f and print maxHp must be greater than 0. maxHp set to 100f by default..
hp should be the same value as maxHp
Method:
Prototype: public void PrintHealth()
Format: <name> has <hp> / <maxHp> health
carrie@ubuntu:~/csharp-delegates_events/0-universal_health$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Player player1 = new Player("Electric Mouse", 500f);
        Player player2 = new Player("Water Turtle");

        player1.PrintHealth();
        player2.PrintHealth();
    }
}
carrie@ubuntu:~/csharp-delegates_events/0-universal_health$ 
carrie@ubuntu:~/csharp-delegates_events/0-universal_health$ dotnet run
Electric Mouse has 500 / 500 health
Water Turtle has 100 / 100 health
carrie@ubuntu:~/csharp-delegates_events/0-universal_health$ 
Repo:

GitHub repository: atlas-csharp
Directory: csharp-delegates_events
File: 0-universal_health/, 0-universal_health/0-universal_health.csproj