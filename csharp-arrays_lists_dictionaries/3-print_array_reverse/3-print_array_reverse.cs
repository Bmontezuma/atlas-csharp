using System;
using System.Linq;

class Array {
    public static void Reverse(int[] array) {
        string s = "";
        if (array != null)
            s = string.Format("{0}", array.Length > 0 ? string.Join(" ", array.Reverse()) : "");
        Console.WriteLine(s);
    }
}
