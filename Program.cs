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

            string input;

            bool repeat = true;
            while (repeat == true)
            {
                try
                {
                    Console.Write("Enter a word to translate:");
                    input = Console.ReadLine();
                    input = input.ToLower();

                    if (input.Length < 3)
                    {
                        Console.WriteLine("Please input a word of 3 letters or more");
                    }
                  
                    //const string vowels = "aeiouAEIOU";
                    List<char> sentence = new List<char>() {'a', 'e', 'i','o','u'};
                    char vowels = input.ToCharArray()[0];

                    foreach (string word in input.Split(' '))
                    {
                        string pig1 = input.Substring(0, 2);
                        string pig2 = input.Substring(1, input.Length-1);
                        int letter = input.IndexOf(word);

                        if (letter == -1)
                        {
                            Console.WriteLine(pig2 + pig1 + "ay");

                        } 
                        else if (input.Contains(vowels))
                        {
                            Console.WriteLine(word + "way");
                        }
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Please use real letters only");
                }
                
                repeat = Continue();
            }
        }
        public static bool Continue()
        {
            Console.WriteLine("Do you wish to Continue? y/n");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }
            return goOn;
        }
    }
}
