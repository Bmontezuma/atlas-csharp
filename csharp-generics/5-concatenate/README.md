# ***5. Concatenate***

Based on ***4-print***, create a method ***Concatenate()*** that concatenates all values in the queue only if the queue is of type ***String*** or ***Char***.

- ***If queue is empty***, print ***Queue is empty*** and return ***null***
- If the queue is not of type ***String*** or ***Char***, print ***Concatenate()*** is for a queue of ***Strings*** or ***Chars*** only to the console and return ***null***
```csharp
carrie@ubuntu:~/csharp-generics/5-concatenate$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> myStrQ = new Queue<string>();

        myStrQ.Enqueue("hello");
        myStrQ.Enqueue("holberton");
        myStrQ.Enqueue("school");

        Console.WriteLine(myStrQ.Concatenate());

        Console.WriteLine("----------");

        Queue<int> myIntQ = new Queue<int>();
        myIntQ.Concatenate();

        Console.WriteLine("----------");

        Queue<char> myCharQ = new Queue<char>();
        myCharQ.Enqueue('a');
        myCharQ.Enqueue('b');
        myCharQ.Enqueue('c');
        Console.WriteLine(myCharQ.Concatenate());
    }
}
carrie@ubuntu:~/csharp-generics/5-concatenate$
carrie@ubuntu:~/csharp-generics/5-concatenate$
hello holberton school
----------
Queue is empty
----------
abc
carrie@ubuntu:~/csharp-generics/5-concatenate$
```
## ***Repo***:

***GitHub repository: atlas-csharp***\
***Directory: csharp-generics***\
***File: 5-concatenate/, 5-concatenate/5-concatenate.csproj, 5-concatenate/queue.cs***