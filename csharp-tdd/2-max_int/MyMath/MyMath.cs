using System.Collections.Generic;
using System.Linq;

namespace MyMath
{
    /// <summary>
    /// Class containing mathematical operations.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Returns the maximum integer in a list of integers.
        /// </summary>
        /// <param name="nums">List of integers.</param>
        /// <returns>The maximum integer in the list. Returns 0 if the list is empty.</returns>
        public static int Max(List<int> nums)
        {
            // If the list is null or empty, return 0
            if (nums == null || nums.Count == 0)
                return 0;

            // Otherwise, return the maximum value in the list
            return nums.Max();
        }
    }
}
