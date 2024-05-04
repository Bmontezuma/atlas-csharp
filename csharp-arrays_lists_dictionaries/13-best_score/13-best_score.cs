using System;
using System.Collections.Generic;

public static class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
        {
            return "None";
        }

        int maxValue = int.MinValue;
        string maxKey = "";

        foreach (KeyValuePair<string, int> entry in myList)
        {
            if (entry.Value > maxValue)
            {
                maxValue = entry.Value;
                maxKey = entry.Key;
            }
        }

        return maxKey;
    }
}
