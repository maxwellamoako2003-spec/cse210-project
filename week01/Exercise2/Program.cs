using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Stretch Challenge 1: Determine the plus or minus sign
        int lastDigit = percent % 10;
        string sign = "";

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Stretch Challenge 2: No A+ grade
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        // Stretch Challenge 3: No F+ or F- grades
        if (letter == "F")
        {
            sign = "";
        }

        // Display the letter grade and sign
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Core Requirement 2: Check whether the student passed
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }


    }
}