using System;

namespace Obj
{
    public static class Obj
    {
        /// <summary>
        /// Returns True if the object is an int, otherwise return False.
        /// </summary>
        /// <param name="obj">The object to check.</param>
        /// <returns>True if the object is an int, otherwise False.</returns>
        public static bool IsOfTypeInt(object obj)
        {
            return obj is int;
        }

        static void Main(string[] args)
        {
            var a = 10;
            var b = new List<int>();

            if (IsOfTypeInt(a))
                Console.WriteLine("{0} is of type int", nameof(a));
            else
                Console.WriteLine("{0} is NOT of type int", nameof(a));

            if (IsOfTypeInt(b))
                Console.WriteLine("{0} is of type int", nameof(b));
            else
                Console.WriteLine("{0} is NOT of type int", nameof(b));
        }
    }
}
