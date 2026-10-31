
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Collect numbers until the user enters 0
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Check that the list is not empty
        if (numbers.Count > 0)
        {
            // Core Requirement 1: Compute the sum
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"The sum is: {sum}");

            // Core Requirement 2: Compute the average
            double average = (double)sum / numbers.Count;

            Console.WriteLine($"The average is: {average}");

            // Core Requirement 3: Find the largest number
            int largest = numbers[0];

            foreach (int number in numbers)
            {
                if (number > largest)
                {
                    largest = number;
                }
            }

            Console.WriteLine($"The largest number is: {largest}");

            // Stretch Challenge 1: Find the smallest positive number
            int? smallestPositive = null;

            foreach (int number in numbers)
            {
                if (number > 0 &&
                    (smallestPositive == null ||
                     number < smallestPositive.Value))
                {
                    smallestPositive = number;
                }
            }

            if (smallestPositive.HasValue)
            {
                Console.WriteLine(
                    $"The smallest positive number is: {smallestPositive.Value}");
            }

            // Stretch Challenge 2: Sort the list
            numbers.Sort();

            Console.WriteLine("The sorted list is:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
