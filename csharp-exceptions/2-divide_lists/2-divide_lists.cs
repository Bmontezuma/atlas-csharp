using System;
using System.Collections.Generic;

public class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> resultList = new List<int>();

        try
        {
            for (int i = 0; i < listLength; i++)
            {
                int dividend = list1[i];
                int divisor = list2[i];

                if (divisor == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    resultList.Add(0);
                }
                else
                {
                    int result = dividend / divisor;
                    resultList.Add(result);
                }
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Out of range");
        }

        return resultList;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> list1 = new List<int>() { 1, 20, 16, 15, 54 };
        List<int> list2 = new List<int>() { 1, 0, 2, 3 };
        List<int> result = List.Divide(list1, list2, 5);

        foreach (int i in result)
            Console.WriteLine(i);
    }
}
