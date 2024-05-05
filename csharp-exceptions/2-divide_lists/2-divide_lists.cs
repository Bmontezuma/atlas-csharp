using System;
using System.Collections.Generic;
using static System.Console;

public class ListExtensions
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < listLength; i++)
        {
            try
            {
                int dividend = list1[i];
                int divisor = list2[i];

                if (divisor == 0)
                {
                    WriteLine("Cannot divide by zero");
                    result.Add(0);
                }
                else
                {
                    int divisionResult = dividend / divisor;
                    result.Add(divisionResult);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                WriteLine("Out of range");
                result.Add(0); // Add a placeholder value for out-of-range indices
            }
        }

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> list1 = new List<int>() { 1, 20, 16, 15, 54 };
        List<int> list2 = new List<int>() { 1, 0, 2, 3 };
        int listLength = Math.Max(list1.Count, list2.Count);

        List<int> result = ListExtensions.Divide(list1, list2, listLength);

        foreach (int value in result)
            WriteLine(value);
    }
}
