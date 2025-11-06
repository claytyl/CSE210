using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int value;

            if (!int.TryParse(input, out value))
            {
                Console.WriteLine("Please enter a valid integer.");
                continue;
            }

            if (value == 0)
                break;

            numbers.Add(value);
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        int sum = 0;
        foreach (int n in numbers)
            sum += n;
        Console.WriteLine($"The sum is: {sum}");

        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int n in numbers)
            if (n > max) max = n;
        Console.WriteLine($"The largest number is: {max}");
    }
}
