using System;
using System.Linq;

namespace Text
{
    /// <summary>
    /// Class containing string manipulation methods.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Checks if a string is a palindrome.
        /// </summary>
        /// <param name="s">Input string.</param>
        /// <returns>True if string is a palindrome, False otherwise.</returns>
        public static bool IsPalindrome(string s)
        {
            // Remove spaces and punctuation, convert to lowercase
            string cleanedString = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();

            // Compare the cleaned string with its reverse
            return cleanedString.SequenceEqual(cleanedString.Reverse());
        }
    }
}
