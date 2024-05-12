using System;

namespace Text
{
    /// <summary>
    /// Class containing string manipulation methods.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Determines the number of words in a camelCase string.
        /// </summary>
        /// <param name="s">Input string.</param>
        /// <returns>The number of words in the string.</returns>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int wordCount = 1;
            foreach (char c in s)
            {
                if (char.IsUpper(c))
                    wordCount++;
            }
            return wordCount;
        }
    }
}
