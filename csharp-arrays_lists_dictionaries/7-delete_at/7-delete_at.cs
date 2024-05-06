using System;
using System.Collections.Generic;

class ListHelper {
    public static void DeleteAt(List<int> myList, int index) {
        if (index < 0 || index > myList.Count - 1) {
            Console.WriteLine("Index is out of range");
            return;
        }
        myList.RemoveAt(index);
    }
}
