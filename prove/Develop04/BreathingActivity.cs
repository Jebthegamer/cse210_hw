using System.Data;

public class BreathingActivity : Activity
{
    // The constructor for the Breathing Activity.
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }
    // This is the main body of the activity. This does everything except set the duration.
    public void RunActivity()
    {
        // Determine the number of breaths which will be taken.
        int breathCount = base.GetDuration() / 10;
        // If it's not a perfect multiple of ten, add another breath.
        if (base.GetDuration() % 10 != 0)
        {
            breathCount ++;
        }
        // Display the animation then tell the user to inhale and exhale until the timer is done. 
        // Notably, the countdowns have a total of 10 seconds between them, meaning that DateTime is not needed.
        Animation(5);
        Console.WriteLine("");
        while (breathCount != 0)
        {       
            Console.Write("Breathe in...");
            CountDown(4);
            Console.WriteLine("");
            Console.Write("Breathe out...");
            CountDown(6);
            Console.WriteLine("");
            Console.WriteLine("");
            breathCount--;
        }
        EndingMessage();

    }
    // The animation for the Breathing Activity.
    private void Animation(int seconds)
    {
        while (seconds != 0)
        {
            Console.Write(" [] ");
            Thread.Sleep(500);
            ClearAnimation(4);
            Console.Write("{  }");
            Thread.Sleep(500);
            ClearAnimation(4);
            seconds--;
        }
    }
    
}