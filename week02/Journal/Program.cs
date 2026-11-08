
using System;

class Program
{
    static void Main(string[] args)
    {
        // Extra feature: Users can record their mood with each journal entry.
        // The mood is displayed and saved along with the date, prompt, and response.

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string input = Console.ReadLine() ?? "";

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Please enter a number from 1 to 5.");
                choice = 0;
                continue;
            }

            switch (choice)
            {
                case 1:
                    string prompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine(prompt);
                    Console.Write("Your response: ");
                    string response = Console.ReadLine() ?? "";

                    while (string.IsNullOrWhiteSpace(response))
                    {
                        Console.WriteLine("Your response cannot be empty.");
                        Console.Write("Please write your response: ");
                        response = Console.ReadLine() ?? "";
                    }

                    Console.WriteLine("How are you feeling today?");
                    Console.WriteLine("1. Happy");
                    Console.WriteLine("2. Grateful");
                    Console.WriteLine("3. Excited");
                    Console.WriteLine("4. Worried");
                    Console.WriteLine("5. Peaceful");
                    Console.Write("Choose your mood: ");

                    string moodChoice = Console.ReadLine() ?? "";

                    string mood = moodChoice switch
                    {
                        "1" => "Happy",
                        "2" => "Grateful",
                        "3" => "Excited",
                        "4" => "Worried",
                        "5" => "Peaceful",
                        _ => "Not specified"
                    };

                    string date = DateTime.Now.ToShortDateString();

                    Entry entry = new Entry(date, prompt, response, mood);
                    journal.AddEntry(entry);
                    break;

                case 2:
                    journal.DisplayAll();
                    break;

                case 3:
                    Console.Write("Enter filename: ");
                    string saveFile = Console.ReadLine() ?? "";
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved successfully.");
                    break;

                case 4:
                    Console.Write("Enter filename: ");
                    string loadFile = Console.ReadLine() ?? "";
                    journal.LoadFromFile(loadFile);
                    break;

                case 5:
                    Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Please select a number from 1 to 5.");
                    break;
            }
        }
    }
}
