public class Activity
{
    public string ActivityName { get; set; }
    public int Duration { get; set; }
    public string Description { get; set; }

    public void WelcomeMessage()
    {
        Console.WriteLine($"Welcome to the {ActivityName}.");
        Console.WriteLine("");
        Console.WriteLine(Description);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        Duration = int.Parse(Console.ReadLine());
    }

    public void EndingMessage()
    {
        Console.WriteLine("Well done!");

        Thread.Sleep(500);

        Console.WriteLine("");
        Console.WriteLine($"You have completed another {Duration} seconds of the {ActivityName}!");
    }
    public void SetDuration(int time)
    {
        Duration = time;
    }

    public Activity(string name, string description)
    {
        ActivityName = name;
        Description = description;
    }
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
}