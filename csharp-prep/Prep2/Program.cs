using System;


class Program
{
    static void Main()
    {
        Console.Write("Enter your grade percentage: ");
        double grade = double.Parse(Console.ReadLine());

        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        // Determine if the user passed or not
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Don't give up! Study hard and you'll do better next time!");
        }
    }
}
