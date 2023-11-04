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
    // The constructor for ReflectionActivity.
    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }
    // The main body of the activity. This runs the entire activity's functionality in Program.cs, with the exception of setting the duration.
    public void RunActivity()
    {
        // Create a randomizer, select a random prompt
        var random = new Random();
        int index = random.Next(_prompts.Count());
        // Print the instructions.
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
        // Display the clarifying messages with a five second delay in between. DateTime isn't needed as the animation lasts for five seconds.
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
    // The animation for the ReflectionActivity. Each iteration of the loop takes one second, meaning that DateTime won't be needed for this activity.
    private void Animation(int seconds)
    {
        // For fun, I decided to have this alternate between two separate animations.
        bool alternate = true;
        while (seconds != 0)
        {
            if (alternate)
            {
                // The first will display "(0-0)" over the course of a second and then clear it.
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
                // The second will display "0O|O0" over the course of a second and then clear it.
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