using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");

            bool repeat = true;
            while (repeat == true)
            {
                Console.Write("Enter a word to translate:");
                string input = Console.ReadLine();
                input = input.ToLower();
                
                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I','O','U' };
                List<string> sentence = new List<string>();

                foreach (string word in input.Split(' '))
                {
                    string pig1 = word.Substring(0,3);
                    string pig2 = word.Substring(1, word.Length - 1);
                    int letter = vowels.IndexOf(pig1);

                    if (letter ==-1)
                    {
                        Console.WriteLine(pig1+pig2+"ay");

                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }

                Console.WriteLine("Would you like to run the program again? Y or N");
                string answer = Console.ReadLine();
                answer = answer.ToLower();

                if(answer != "y")
                {
                    repeat = false;
                }
            }
        }
    }
}
