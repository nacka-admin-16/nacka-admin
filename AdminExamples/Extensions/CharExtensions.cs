using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
