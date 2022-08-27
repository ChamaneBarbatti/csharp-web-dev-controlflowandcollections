using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int total = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    total += number;
                }
            }
            Console.WriteLine(total);





            List<string> word = new List<string>();
            word.Add("Hello");
            word.Add("Four");
            word.Add("Hi");
            foreach (string w in word) {
                Console.WriteLine(w);
    }
            Console.WriteLine("using this method");
            printFiveLetterWords(word);
            
            static void printFiveLetterWords(List<string> wordlist)
            {

                foreach (string word in wordlist)
                {
                    if (word.Length == 5)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }

    }
}
