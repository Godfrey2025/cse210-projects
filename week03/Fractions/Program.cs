using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        // Using constructor with no parameters
        Fraction f1 = new Fraction();
        Console.WriteLine($"f1: {f1.GetFractionString()} = {f1.GetDecimalValue()}");

        // Using constructor with one parameter
        Fraction f2 = new Fraction(6);
        Console.WriteLine($"f2: {f2.GetFractionString()} = {f2.GetDecimalValue()}");

        // Using constructor with two parameters
        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine($"f3: {f3.GetFractionString()} = {f3.GetDecimalValue()}");
    }
}