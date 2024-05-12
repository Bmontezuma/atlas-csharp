using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// Class containing string manipulation methods.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Returns the index of the first non-repeating character in a string.
        /// </summary>
        /// <param name="s">Input string.</param>
        /// <returns>Index of the first non-repeating character, or -1 if there is none.</returns>
        public static int UniqueChar(string s)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Count occurrences of each character
            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            // Find the first character with count 1
            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i]] == 1)
                {
                    return i;
                }
            }

            // No non-repeating character found
            return -1;
        }
    }
}
