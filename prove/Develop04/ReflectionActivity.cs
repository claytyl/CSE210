
public class ReflectionActivity : Base
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Queue<string> unusedQuestions;
    private Random rand = new Random();

    public ReflectionActivity()
        : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        ResetQuestions();
    }

    private void ResetQuestions()
    {
        unusedQuestions = new Queue<string>(questions);
    }

    private string GetRandomQuestion()
    {
        if (unusedQuestions.Count == 0)
            ResetQuestions();
        var questionArray = unusedQuestions.ToArray();
        string selected = questionArray[rand.Next(questionArray.Length)];
        var temp = new Queue<string>();
        foreach (var q in unusedQuestions)
        {
            if (q != selected) temp.Enqueue(q);
        }
        unusedQuestions = temp;
        return selected;
    }

    public override void RunActivity()
    {
        Start();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(prompt);
        ShowCountdown(3);

        int elapsed = 0;
        while (elapsed < Duration)
        {
            string question = GetRandomQuestion();
            Console.WriteLine(question);
            ShowCountdown(5);
            elapsed += 5;
        }
        End();
    }
}