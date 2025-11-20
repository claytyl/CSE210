//Exceeds requirements, as there are no repeat prompts until all are used.

using System;
using System.Collections.Generic;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMindfulness Activities Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            if (choice == "4") break;

            Console.Write("Enter duration in seconds: ");
            int duration = int.Parse(Console.ReadLine());

            Base activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                _ => null
            };

            if (activity != null)
            {
                activity.SetDuration(duration);
                activity.RunActivity();
            }
            else
            {
                Console.WriteLine("Invalid choice, try again.");
            }
        }
    }
}
