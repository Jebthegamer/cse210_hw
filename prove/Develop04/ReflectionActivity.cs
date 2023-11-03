public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you helped someone else",
        "Think of when you learnt an important lesson",
        "Think of one instance where you felt God's hand in your life"
    };
    private List<string> _clarifications = new List<string>
    {
        
        "How did this make you feel?",
        "Why was this experience meaningful to you?",
        "What started this experience?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }
    public void RunActivity()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count());
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
        int count = base.GetDuration();
        while (count != 0)
        {
            index = random.Next(_clarifications.Count);
            Console.Write($"> {_clarifications[index]} ");
            Animation(5);
            Console.Write("\n");
            count -= 5;
        }
        Console.Clear();
        EndingMessage();

    }
    private void Animation(int seconds)
    {
        bool alternate = true;
        while (seconds != 0)
        {
            if (alternate)
            {
                Console.Write("(0");
                Thread.Sleep(250);
                Console.Write("-");
                Thread.Sleep(250);
                Console.Write("0)");
                Thread.Sleep(250);
                ClearAnimation(5);
                Thread.Sleep(250);
                seconds--;
                alternate = false;
            }
            else
            {
                Console.Write("0O");
                Thread.Sleep(250);
                Console.Write(" | ");
                Thread.Sleep(250);
                Console.Write("O0");
                Thread.Sleep(250);
                ClearAnimation(7);
                Thread.Sleep(250);
                seconds--;
                alternate = true;
            }
        }
    }
}