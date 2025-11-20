
public abstract class Base
{
    protected string Name;
    protected string Description;
    protected int Duration; // in seconds

    public Base(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void SetDuration(int duration)
    {
        Duration = duration;
    }

    public void Start()
    {
        Console.WriteLine($"\nStarting {Name} Activity");
        Console.WriteLine(Description);
        Console.WriteLine($"Duration: {Duration} seconds");
        Console.WriteLine("Get ready...");
        ShowCountdown(3);
    }

    public void End()
    {
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
        ShowCountdown(3);
    }

    // Countdown using Thread.Sleep for accurate timing
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000); // wait exactly 1 second
        }
        Console.WriteLine();
    }

    public abstract void RunActivity();
}