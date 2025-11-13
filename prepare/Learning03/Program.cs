using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fraction Class Test\n");

        Fraction f1 = new Fraction();
        Console.WriteLine($"f1 (default): {f1.GetFractionString()} = {f1.GetDecimalValue()}");

        Fraction f2 = new Fraction(5);
        Console.WriteLine($"f2 (top only): {f2.GetFractionString()} = {f2.GetDecimalValue()}");

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine($"f3 (top and bottom): {f3.GetFractionString()} = {f3.GetDecimalValue()}");

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine($"f4: {f4.GetFractionString()} = {f4.GetDecimalValue()}");

        f3.SetTop(6);
        f3.SetBottom(7);
        Console.WriteLine($"\nAfter using setters on f3:");
        Console.WriteLine($"New f3 fraction: {f3.GetFractionString()} = {f3.GetDecimalValue()}");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}