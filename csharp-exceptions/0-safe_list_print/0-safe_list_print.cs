using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        try
        {
            int count = 0;
            foreach (int num in myList)
            {
                Console.WriteLine(num);
                count++;
                if (count == n)
                    break;
            }
            return count;
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
            return 0;
        }
    }
}
