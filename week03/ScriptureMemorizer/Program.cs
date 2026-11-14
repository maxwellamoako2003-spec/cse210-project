
using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity: The program has a small scripture library
        // and randomly selects a scripture for the user to memorize.
        // It also hides only words that are not already hidden.

        Scripture[] scriptures =
        {
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding"
            ),

            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son"
            )
        };

        Random random = new Random();

        Scripture scripture = scriptures[
            random.Next(scriptures.Length)
        ];

        while (true)
        {
            Console.Clear();

            Console.WriteLine("SCRIPTURE MEMORIZER");
            Console.WriteLine();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Well done! You have hidden all the words.");
                break;
            }

            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");

            string input = Console.ReadLine() ?? "";

            if (input.Trim().ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}
