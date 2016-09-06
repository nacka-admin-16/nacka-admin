using System;
using AdminExamples.Examples;

namespace AdminExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en bokstav");
            Console.WriteLine();

            var letter = Console.ReadLine();
            var isVowel = Repository.IsVowel(letter);
            var message = isVowel ? "Detta är en vokal" : "Detta är inte en vokal";

            Console.WriteLine();
            Console.WriteLine(message);

            Console.WriteLine();
            Console.WriteLine("Tryck enter för att avsluta programmet");
            Console.ReadLine();
        }
    }
}
