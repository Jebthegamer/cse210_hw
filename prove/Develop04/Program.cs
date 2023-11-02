using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        BreathingActivity breathingActivity = new();
        breathingActivity.WelcomeMessage();
        breathingActivity.RunActivity();
        */
        ReflectionActivity reflectionActivity = new();
        reflectionActivity.WelcomeMessage();
        reflectionActivity.AddPrompt("Think of a time you helped someone else");
        reflectionActivity.AddPrompt("Think of when you learnt an important lesson");
        reflectionActivity.AddPrompt("Think of one instance where you felt God's hand in your life");
        reflectionActivity.AddClarification("How did this make you feel?");
        reflectionActivity.AddClarification("Why was this experience meaningful to you?");
        reflectionActivity.AddClarification("What started this experience?");
        reflectionActivity.AddClarification("What did you learn about yourself through this experience?");
        reflectionActivity.AddClarification("How can you keep this experience in mind in the future?");
        reflectionActivity.RunActivity();
    }
}
