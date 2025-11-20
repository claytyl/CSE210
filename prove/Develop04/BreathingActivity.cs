
public class BreathingActivity : Base
{
    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void RunActivity()
    {
        Start();
        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            elapsed += 4;
            if (elapsed >= Duration) break;

            Console.WriteLine("Breathe out...");
            ShowCountdown(6);
            elapsed += 6;
        }
        End();
    }
}