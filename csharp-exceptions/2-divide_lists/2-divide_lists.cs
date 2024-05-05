using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> resultList = new List<int>();

        try
        {
            for (int i = 0; i < listLength; i++)
            {
                int dividend = i < list1.Count ? list1[i] : 0;
                int divisor = i < list2.Count ? list2[i] : 1; // Default divisor to 1 to avoid division by zero

                try
                {
                    int result = dividend / divisor;
                    resultList.Add(result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero");
                    resultList.Add(0);
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
