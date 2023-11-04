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
    // Constructor for the Listing Activity.
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }
    // The main body of the activity. This does everything except set the duration.
    public void RunActivity()
    {
        // Select a random prompt, then print the menu.
        var random = new Random();
        int index = random.Next(_prompts.Count());
        Animation(5);
        Console.WriteLine("");
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[index]} ---");
        Console.WriteLine("You may begin in: ");
        CountDown(3);
        Console.WriteLine("");
        // Set the current date and time to figure out when this needs to end.
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(base.GetDuration());
        int counter = 0;
        DateTime currentTime = DateTime.Now;
        // Iterate through the loop, adding one to the counter and tracking the current time.
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            currentTime = DateTime.Now;
            counter++;
        }
        // When done, display the final results.
        Console.WriteLine($"You listed {counter} items!");

        EndingMessage();


    }
    // The animation for the Listing Activity. 
    private void Animation(int seconds)
    {
        // Set the desired length of each line.
        int lineLength = 10;
        // Figure out how many underscores will be displayed in total.
        int repetitions = seconds * 10;
        // Until all underscores are displayed, go through the loop.
        while (repetitions != 0)
        {
            // If the animation is supposed to go to the next line, go to the next line.
            if (repetitions % lineLength == 0)
            {
                Console.WriteLine("");
            }
            // Print the 'pen,' clear it, then place down an underscore.
            Console.Write("/");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("_");
            repetitions--;
        }
        // After the loop is over, the 'pen' will be gone, meaning a new one will need to be made.
        Console.Write("/");
    }
}