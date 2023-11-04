using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        // Start a loop
        bool remain = true;
        while (remain)
        {
            // Print the menu options
            Console.Clear();
            Console.WriteLine("Menu options: ");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflecting Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();

            // Go through the menu and select the related activity.
            if (choice == 1)
            {
                BreathingActivity breathingActivity = new();
                breathingActivity.WelcomeMessage();
                breathingActivity.RunActivity();
            }
            else if (choice == 2)
            {
                ReflectionActivity reflectionActivity = new();
                reflectionActivity.WelcomeMessage();
                reflectionActivity.RunActivity(); 
            }
            else if (choice == 3)
            {
                ListingActivity listingActivity = new();
                listingActivity.WelcomeMessage();
                listingActivity.RunActivity();
            }
            else if (choice == 4)
            {
                // If the choice is four, end the loop.
                remain = false;
            }
            else
            {
                // If the input is invalid, print this message.
                Console.WriteLine("Invalid input; please enter a valid input.");
            }
        }
    }
}
