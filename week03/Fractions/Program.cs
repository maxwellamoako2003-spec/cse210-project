
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create fractions using all three constructors
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);

        // Test getters and setters
        Fraction testFraction = new Fraction();

        testFraction.SetTop(6);
        testFraction.SetBottom(7);

        Console.WriteLine("Testing Getters and Setters:");
        Console.WriteLine($"Top: {testFraction.GetTop()}");
        Console.WriteLine($"Bottom: {testFraction.GetBottom()}");

        Console.WriteLine();

        // Display the fractions
        Console.WriteLine("Fraction Representations:");

        DisplayFraction(fraction1);
        DisplayFraction(fraction2);
        DisplayFraction(fraction3);
        DisplayFraction(fraction4);
    }

    static void DisplayFraction(Fraction fraction)
    {
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
    }
}
