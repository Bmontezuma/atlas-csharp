using System;
using System.Collections.Generic;

public static class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);

        set1.SymmetricExceptWith(set2);

        List<int> result = new List<int>(set1);
        result.Sort();

        return result;
    }
}
