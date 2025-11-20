
public class ListingActivity : Base
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Queue<string> unusedPrompts;
    private Random rand = new Random();

    public ListingActivity()
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        ResetPrompts();
    }

    private void ResetPrompts()
    {
        unusedPrompts = new Queue<string>(prompts);
    }

    private string GetRandomPrompt()
    {
        if (unusedPrompts.Count == 0)
            ResetPrompts();
        var promptArray = unusedPrompts.ToArray();
        string selected = promptArray[rand.Next(promptArray.Length)];
        var temp = new Queue<string>();
        foreach (var p in unusedPrompts)
        {
            if (p != selected) temp.Enqueue(p);
        }
        unusedPrompts = temp;
        return selected;
    }

    public override void RunActivity()
    {
        Start();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("You have 5 seconds to start thinking...");
        ShowCountdown(5);

        int elapsed = 0;
        List<string> items = new List<string>();
        while (elapsed < Duration)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input)) items.Add(input);
            elapsed += 1; // simple approximation
        }

        Console.WriteLine($"You listed {items.Count} items!");
        End();
    }
}
