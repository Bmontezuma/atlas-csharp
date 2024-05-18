# ***1. Enqueue***

Based on ***0-queue***, within ***Queue<T>***, create a public class called Node with the following properties:

- ***value***: can be of any type, set its initial value to ***null***
- ***next***: must be an object of type ***Node***, set its initial value to ***null***
- Define a constructor that takes a ***value*** for a new ***Node*** as its only parameter and sets it

Within ***Queue<T>***, add the following properties:

- ***head***: must be an object of type ***Node***
- ***tail***: must be an object of type ***Node***
- ***count***: type ***int***

Add a new method ***Enqueue()*** to the class ***Queue*** that creates a new ***Node*** and adds it to the end of the queue.

- If the queue is empty, the method should make the new node the head of the queue
- ***count*** should update every time a new node is added

Add a new method ***Count()*** to the class that returns the number of nodes in the Queue.
```csharp
carrie@ubuntu:~/csharp-generics/1-enqueue$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> myStrQ = new Queue<string>();

        myStrQ.Enqueue("Hello");
        Console.WriteLine("Number of nodes in queue: " + myStrQ.Count());

        myStrQ.Enqueue("World");
        Console.WriteLine("Number of nodes in queue: " + myStrQ.Count());

        Console.WriteLine("----------");

        Queue<float> myFloatQ = new Queue<float>();

        myFloatQ.Enqueue(4.2f);
        myFloatQ.Enqueue(4.2f);
        myFloatQ.Enqueue(4.2f);
        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());

        myFloatQ.Enqueue(-9.8f);
        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());
    }
}
carrie@ubuntu:~/csharp-generics/1-enqueue$
carrie@ubuntu:~/csharp-generics/1-enqueue$ dotnet run
Number of nodes in queue: 1
Number of nodes in queue: 2
----------
Number of nodes in queue: 3
Number of nodes in queue: 4
carrie@ubuntu:~/csharp-generics/1-enqueue$
```
## ***Repo***:

***GitHub repository: atlas-csharp***
***Directory: csharp-generics***
***File: 1-enqueue/, 1-enqueue/1-enqueue.csproj, 1-enqueue/queue.cs***