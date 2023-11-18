public class Activity
{
    private string ActivityName { get; set; }
    private int Duration { get; set; }
    private string Description { get; set; }

    // The welcome message for all of the activities. This also sets the duration.
    public void WelcomeMessage()
    {
        Console.WriteLine($"Welcome to the {ActivityName}.");
        Console.WriteLine("");
        Console.WriteLine(Description);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        Console.Clear();
    }
    // A getter for Duration
    public int GetDuration()
    {
        return Duration;
    }
    // The ending message for the activities.
    public void EndingMessage()
    {
        Console.WriteLine("Well done!");
        IdleAnimation(5);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {Duration} seconds of the {ActivityName}!");
        IdleAnimation(5);
    }
    //  The constructor for the Activity class.
    public Activity(string name, string description)
    {
        ActivityName = name;
        Description = description;
    }
    // This clears an animation from the screen and sets the cursor to begin the next one.
    public void ClearAnimation(int animationLength)
    {
        int count = 0;
        while (count != animationLength)
        {
            Console.Write("\b");
            count++;
        }
        count = 0;
        while(count != animationLength)
        {
            Console.Write(" ");
            count++;
        }
        count = 0;
        while (count != animationLength)
        {
            Console.Write("\b");
            count++;
        }
    }
    // This does a countdown.
    public void CountDown(int seconds)
    {
        while (seconds != 0)
            {
                Console.Write(seconds);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                seconds--;
            }
    }
    // The animation for the ending message.
    private void IdleAnimation(int seconds)
    {
        while (seconds != 0)
        {
            int x = 0;
            while (x < 2)
            {
                Console.Write("(");
                Thread.Sleep(200);
                Console.Write(")");
                Thread.Sleep(200);
                x++;
            }
            ClearAnimation(4);
            Thread.Sleep(200);
            seconds--;
        }
    }
}