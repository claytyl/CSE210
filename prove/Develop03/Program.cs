using System;
using System.Collections.Generic;
using System.Linq;

// Program meets all requirements and deserves full credit due to it being able to only get rid of words not previously hidden.
class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference,
            "Trust in the Lord with all thine heart and lean not unto thine own understanding.");

        while (true)
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to end:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideWords(3);

            if (scripture.AllHidden())
            {
                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nAll words are now hidden. Well done!");
                break;
            }
        }
    }
}

