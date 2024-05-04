using System;
using System.Collections.Generic;

public static class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("------");
        Console.WriteLine("Number of items: " + aStack.Count);

        if (aStack.Count > 0)
        {
            Console.WriteLine("Top item: " + aStack.Peek());
        }
        else
        {
            Console.WriteLine("Stack is empty");
            return aStack; // Return early if the stack is empty
        }

        bool found = false;
        Stack<string> tempStack = new Stack<string>();

        while (aStack.Count > 0)
        {
            string item = aStack.Pop();
            tempStack.Push(item);
            if (item == search)
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine("Stack contains " + search + ": True");
            Console.WriteLine("Stack after removing all items up to and including " + search + ":");
            foreach (string item in tempStack)
            {
                if (item != search)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Stack contains " + search + ": False");
        }

        aStack.Push(newItem);

        Console.WriteLine("\nStack after adding " + newItem + ":");
        foreach (string item in aStack)
        {
            Console.Write(item + " ");
        }

        return aStack;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Stack<string> stack0 = new Stack<string>(new string[] { "C", "HTML", "Javascript", "Python", "React", "Ruby" });
        MyStack.Info(stack0, "C#", "Javascript");

        Stack<string> stack1 = new Stack<string>(new string[] { "Physical", "Data Link", "Network", "Transport", "Session", "Presentation" });
        MyStack.Info(stack1, "Application", "Application");

        Stack<string> stack2 = new Stack<string>(new string[] { "C", "HTML", "Javascript", "Python", "React", "Ruby" });
        MyStack.Info(stack2, "C#", "C++");

        Stack<string> stack3 = new Stack<string>();
        MyStack.Info(stack3, "C#", "C++");
    }
}
