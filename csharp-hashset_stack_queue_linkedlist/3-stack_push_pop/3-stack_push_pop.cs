using System;
using System.Collections.Generic;

public static class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: " + aStack.Count);

        if (aStack.Count > 0)
        {
            Console.WriteLine("Top item: " + aStack.Peek());
        }
        else
        {
            Console.WriteLine("Stack is empty");
        }

        if (aStack.Contains(search))
        {
            Console.WriteLine("Stack contains " + search + ": True");

            while (aStack.Count > 0 && aStack.Peek() == search)
            {
                aStack.Pop();
            }

            if (aStack.Count > 0)
            {
                Console.WriteLine("Stack after removing all items up to and including " + search + ":");
                foreach (string item in aStack)
                {
                    Console.Write(item + " ");
                }
            }
            else
            {
                Console.WriteLine("Stack is empty after removing all items up to and including " + search);
            }
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
