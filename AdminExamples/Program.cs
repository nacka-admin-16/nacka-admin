using System;
using AdminExamples.Examples;
using AdminExamples.Extensions;

namespace AdminExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //modul 2, övning 9
            Console.WriteLine("Mata in en bokstav");
            Console.WriteLine();

            var letter = Console.ReadLine();

            if (letter != null)
            {
                var myChar = Convert.ToChar(letter);
                var isVowel = myChar.IsVowel();
                var message = isVowel ? "Detta är en vokal" : "Detta är inte en vokal";

                Console.WriteLine();
                Console.WriteLine(message);
            }

            Console.WriteLine();
            Console.WriteLine("Tryck enter för att avsluta programmet");
            Console.ReadLine();
        }
    }
}