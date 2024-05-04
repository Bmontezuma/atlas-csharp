using System;
using System.Collections.Generic;

public static class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: " + aStack.Count);

        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
            return aStack;
        }

        if (aStack.Contains(search))
        {
            Console.WriteLine("Stack contains " + search + ": True");

            Console.WriteLine("Stack after removing all items up to and including " + search + ":");
            while (aStack.Count > 0 && aStack.Peek() != search)
            {
                Console.Write(aStack.Pop() + " ");
            }
            Console.WriteLine(); // Print a newline after removing items

            aStack.Pop(); // Remove the search item
        }
        else
        {
            Console.WriteLine("Stack contains " + search + ": False");
            return aStack;
        }

        Console.WriteLine("Stack after adding " + newItem + ":");
        aStack.Push(newItem);
        foreach (string item in aStack)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine(); // Print a newline after printing the stack

        return aStack;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Stack<string> stack0 = new Stack<string>(new string[] { "C", "HTML", "Javascript", "Python", "React", "Ruby" });
        Console.WriteLine("------");
        MyStack.Info(stack0, "C#", "Javascript");

        Stack<string> stack1 = new Stack<string>(new string[] { "Physical", "Data Link", "Network", "Transport", "Session", "Presentation" });
        Console.WriteLine("------");
        MyStack.Info(stack1, "Application", "Application");

        Stack<string> stack2 = new Stack<string>(new string[] { "C", "HTML", "Javascript", "Python", "React", "Ruby" });
        Console.WriteLine("------");
        MyStack.Info(stack2, "C#", "C++");

        Stack<string> stack3 = new Stack<string>();
        Console.WriteLine("------");
        MyStack.Info(stack3, "C#", "C++");
    }
}
