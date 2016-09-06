using System.Linq;

namespace AdminExamples.Examples
{
    public class Repository
    {
        //modul 2, övning 9
        public static bool IsVowel(char letter)
        {
            var vowels = new [] { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };

            return vowels.Contains(letter);   
        }
    }
}