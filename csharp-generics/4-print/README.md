# ***4. Print***

Based on ***3-peek***, add a new method ***Print()*** to the class ***Queue<T>*** that prints the queue, starting from the head.

- ***If the queue is empty***, the method should write ***Queue is empty*** to the console
```csharp
carrie@ubuntu:~/csharp-generics/4-print$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> myStrQ = new Queue<string>();

        myStrQ.Enqueue("hello");
        myStrQ.Enqueue("holberton");
        myStrQ.Enqueue("school");

        myStrQ.Print();

        Console.WriteLine("----------");

        Queue<int> myIntQ = new Queue<int>();
        myIntQ.Print();
    }
}
carrie@ubuntu:~/csharp-generics/4-print$
carrie@ubuntu:~/csharp-generics/4-print$
hello
holberton
school
----------
Queue is empty
carrie@ubuntu:~/csharp-generics/4-print$
```
## ***Repo***:

***GitHub repository: atlas-csharp***\
***Directory: csharp-generics***\
***File: 4-print/, 4-print/4-print.csproj, 4-print/queue.cs***