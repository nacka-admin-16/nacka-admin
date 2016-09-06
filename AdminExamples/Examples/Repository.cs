using System.Collections.Generic;

namespace AdminExamples.Examples
{
    public class Repository
    {
        public static bool IsVowel(string letter)
        {
            var vowels = new List<string> { "a", "e", "i", "o", "u", "y", "å", "ä", "ö" };

            return vowels.Contains(letter);
            //return vowels.Any(vowel => letter == vowel);
        }
    }
}