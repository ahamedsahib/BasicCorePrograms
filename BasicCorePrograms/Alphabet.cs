using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Alphabet
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the Alphabet");
            string aplhabet = Console.ReadLine().ToLower();
            FindVowelConsonat(aplhabet);
        }
        private static void FindVowelConsonat(string letter)
        {
            //using OR operator to check if User Aplhabet match with any of the Vowels
            if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
            {
                Console.WriteLine($"{letter} is  Vowel");
            }
            else
            {
                Console.WriteLine($"{letter} is  Consonant");
            }

        }
    }
}
