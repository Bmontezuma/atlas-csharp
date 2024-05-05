using System;
using System.Collections.Generic;

class ListOperations
{
    public static List<int> DivideLists(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < listLength; i++)
        {
            try
            {
                int dividend = GetValueAtIndexOrDefault(list1, i);
                int divisor = GetValueAtIndexOrDefault(list2, i);

                result.Add(dividend / divisor);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                result.Add(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }

        return result;
    }

    private static int GetValueAtIndexOrDefault(List<int> list, int index)
    {
        return index < list.Count ? list[index] : 0;
    }
}
