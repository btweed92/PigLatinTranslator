using System;

namespace PigLatinCapstone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the Pig Latin translator!");

            bool userChoice = true;
            while (userChoice)
            {
                Console.WriteLine("Please enter a word to be translated: ");
                string userWord = Console.ReadLine();

                UserWords(userWord);
                Console.WriteLine();
                Console.WriteLine("Would you like to translate a word from English to Pig Latin? (y/n)");

                if (Console.ReadLine().ToLower() == "n")
                {
                    userChoice = false;
                    Console.WriteLine("TooAY badAY, haveAY aAY goodAY dayAY.");
                }
                
            }
        }
        public static void UserWords(string userWord)
        {
            userWord = userWord.ToLower();
            string vowels = "aeiou";
            string[] split = userWord.Split(" ");

            foreach (var item in split)
            {
                if (vowels.Contains(item.Substring(0, 1)))
                {
                    string item2;
                    item2 = item + "way ";
                    Console.Write($"{item2}");
                }
                else if (item.Length == 1)
                {
                    Console.Write(item + " ");
                }

                else
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (vowels.Contains(item[i]))
                        {
                            string wordPart1 = item.Substring(0, i);
                            string wordPart2 = item.Substring(i);

                            Console.Write($"{wordPart2}{wordPart1}ay ");

                            break;
                        }
                    }
                }
            }
        }

    }
}


