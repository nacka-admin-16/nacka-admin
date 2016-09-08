using System.Linq;

namespace AdminExamples.Extensions
{
    public static class CharExtensions
    {
        public static bool IsVowel(this char letter)
        {
            var vowels = new [] { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };

            return vowels.Contains(letter);
        }
    }
}