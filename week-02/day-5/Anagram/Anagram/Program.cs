﻿using System;
using System.Linq;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me two words, I tell you if they are anagrams or not.");

            Console.WriteLine("\nWord 1:");
            string word1 = Console.ReadLine();

            var anagram1 = word1.ToCharArray();

            Console.WriteLine("\nWord 2:");
            string word2 = Console.ReadLine();

            var anagram2 = word2.ToCharArray();

            var result = anagram1.Except(anagram2);

            bool success = true;
            success = (result.Count() == 0);

            if (success)
            {
                Console.WriteLine("\nThese two words ARE anagrams");                
            }
            else
            {
                Console.WriteLine("\nThese two words are NOT anagrams");
            }

            Console.ReadLine();
        }
    }
    
}
