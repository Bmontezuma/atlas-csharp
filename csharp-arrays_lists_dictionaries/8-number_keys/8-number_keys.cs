using System;
using System.Collections.Generic;

public static class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int count = 0;

        foreach (KeyValuePair<string, string> entry in myDict)
        {
            count++;
        }

        return count;
    }
}
