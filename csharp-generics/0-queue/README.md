# ***0. Queue***

Create a new class called ***Queue<T>***.

- ***Queue<T>*** should not inherit from other classes or interfaces.
- Within ***Queue<T>***, create a new method ***CheckType()*** that returns the Queue’s type.
- You are not allowed to use ***System.Collections*** or ***System.Collections.Generic*** for this project.
***NOTE***: Your file name for this task will be ***queue.cs*** not ***0-queue.cs*** because we will be using this file in subsequent tasks.
```csharp
carrie@ubuntu:~/csharp-generics/0-queue$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> myStrQ = new Queue<string>();
        Queue<object> myObjQ = new Queue<object>();

        Console.WriteLine($"{nameof(myStrQ)} Queue Type: " + myStrQ.CheckType());
        Console.WriteLine($"{nameof(myObjQ)} Queue Type: " + myObjQ.CheckType());
    }
}
carrie@ubuntu:~/csharp-generics/0-queue$
carrie@ubuntu:~/csharp-generics/0-queue$ dotnet run
myStrQ Queue Type: System.String
myObjQ Queue Type: System.Object
carrie@ubuntu:~/csharp-generics/0-queue$
```
## ***Repo***:

***GitHub repository: atlas-csharp***
***Directory: csharp-generics***
***File: 0-queue/, 0-queue/0-queue.csproj, 0-queue/queue.cs***