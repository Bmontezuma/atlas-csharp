using System;
using System.Collections.Generic;

public static class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> keys = new List<string>(myDict.Keys);
        keys.Sort();

        foreach (string key in keys)
        {
            Console.WriteLine("Key: " + key + ", Value: " + myDict[key]);
        }
    }
}
