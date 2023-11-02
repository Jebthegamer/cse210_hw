public class ReflectionActivity : Activity
{
    private List<string> _prompts { get; set; }
    private List<string> _clarifications { get; set; }
    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>();
        _clarifications = new List<string>();
    }
    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }

    public void AddClarification(string clarification)
    {
        _clarifications.Add(clarification);
    }
    public void RunActivity()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        Console.Clear();
        Console.WriteLine("Get ready...");
        Animation(5);
        Console.WriteLine("");
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"--- {_prompts[index]} ---");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        Console.WriteLine("Now ponder on the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in: ");
        CountDown(3);
        Console.Clear();
        int count = Duration;
        while (count != 0)
        {
            index = random.Next(_clarifications.Count);
            Console.Write($"> {_clarifications[index]} ");
            Animation(5);
            Console.Write("\n");
            count -= 5;
        }
        Console.WriteLine("");
        EndingMessage();

    }
    private void Animation(int seconds)
    {
        bool alternate = true;
        while (seconds != 0)
        {
            if (alternate)
            {
                Console.Write("WM ");
                Thread.Sleep(500);
                Console.Write(" MW");
                Thread.Sleep(500);
                ClearAnimation(6);
                seconds--;
                alternate = false;
            }
            else
            {
                Console.Write("0O ");
                Thread.Sleep(500);
                Console.Write(" O0");
                Thread.Sleep(500);
                ClearAnimation(6);
                seconds--;
                alternate = true;
            }
        }
    }
}