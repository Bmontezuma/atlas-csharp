using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Check if the stack is empty
        if (aStack.Count == 0)
        {
            Console.WriteLine("Number of items: 0");
            Console.WriteLine("Stack is empty");
            return aStack;
        }

        bool hasSearch = aStack.Contains(search);
        Console.WriteLine($"Number of items: {aStack.Count}");
        Console.WriteLine($"Top item: {aStack.Peek()}");
        Console.WriteLine($"Stack contains \"{search}\": {hasSearch}");

        if (hasSearch)
        {
            while (aStack.Count > 0 && aStack.Peek() != search)
            {
                aStack.Pop();
            }

            // Remove the search item
            if (aStack.Count > 0)
            {
                aStack.Pop();
            }
        }

        aStack.Push(newItem);

        return aStack;
    }
}
