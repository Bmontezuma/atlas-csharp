# ***3. Peek***

Based on ***2-dequeue***, add a new method ***Peek()*** to the class ***Queue<T>*** that returns the value of the first node of the queue without removing the node.

***If the queue is empty***, the method should write ***Queue is empty*** to the console and return the default value of the parameter’s type
```csharp
carrie@ubuntu:~/csharp-generics/3-peek$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> myIntQ = new Queue<int>();

        myIntQ.Enqueue(100);
        myIntQ.Enqueue(101);
        myIntQ.Enqueue(102);

        Console.WriteLine("First value: " + myIntQ.Peek());
        Console.WriteLine("Number of nodes in queue: " + myIntQ.Count());

        Console.WriteLine("----------");

        Queue<char> myCharQ = new Queue<char>();
        Console.WriteLine("First value: " + myCharQ.Peek());
    }
}
carrie@ubuntu:~/csharp-generics/3-peek$
carrie@ubuntu:~/csharp-generics/3-peek$
First value: 100
Number of nodes in queue: 3
----------
Queue is empty
First value:
carrie@ubuntu:~/csharp-generics/3-peek$
```
## ***Repo***:

***GitHub repository: atlas-csharp***\
***Directory: csharp-generics***\
***File: 3-peek/, 3-peek/3-peek.csproj, 3-peek/queue.cs***