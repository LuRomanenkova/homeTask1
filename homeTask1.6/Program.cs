using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace homeTask1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Please, enter some text");
            string words_ = Console.ReadLine();
            string[] delimiterChars = { " ", ",", ".", ":", "-" };
            string[] words = words_.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

            int symbolsCount = 0;
            string lastSymbols = "";

            foreach (var word in words)
            {
                Console.WriteLine($"{word}");
                symbolsCount += word.Length;
                if (word[word.Length - 1] != '"')
                {
                    lastSymbols += word[word.Length - 1];
                }
                else
                {
                    lastSymbols += word[word.Length - 2];
                }
                
               
            }

            lastSymbols.Reverse();

            Console.WriteLine($"Words count: {words.Length};");
            Console.WriteLine($"Symbols without space count: {symbolsCount};");
            Console.WriteLine($@"Relation count symbols without space to words count: 
                                                        {String.Format("{0:0.00}", symbolsCount / words.Length)};");
            Console.WriteLine($"Word is built using last symbol from each word: '{lastSymbols}'.");


        }
    }
}