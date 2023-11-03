using System.Data;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }
    public void RunActivity()
    {
        int breathCount = base.GetDuration() / 10;
        if (base.GetDuration() % 10 != 0)
        {
            breathCount ++;
        }
        Console.WriteLine("Get ready...");
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