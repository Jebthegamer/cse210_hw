public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }
    public void RunActivity()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count());
        Console.WriteLine("Get ready...");
        Animation(5);
        Console.WriteLine("");
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[index]} ---");
        Console.WriteLine("You may begin in: ");
        CountDown(3);
        Console.WriteLine("");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(base.GetDuration());
        int counter = 0;
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            currentTime = DateTime.Now;
            counter++;
        }
        Console.WriteLine($"You listed {counter} items!");

        EndingMessage();


    }
    private void Animation(int seconds)
    {
        int lineLength = 10;
        int repetitions = seconds * 10;
        while (repetitions != 0)
        {
            if (repetitions % lineLength == 0)
            {
                Console.WriteLine("");
            }
            Console.Write("/");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("_");
            repetitions--;
        }
        Console.Write("/");
    }
}