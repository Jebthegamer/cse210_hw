using System;
//Use serialization for file saving
class Program
{
    static void Main(string[] args)
    {
        bool remain = true;
        int points = 0;
        int choice;
        while (remain)
        {
            Console.WriteLine($"You have {points} points");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create new goal");
            Console.WriteLine("  2. List goals");
            Console.WriteLine("  3. Save goals");
            Console.WriteLine("  4. Load goals");
            Console.WriteLine("  5. Record event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                // Create a goal
                Console.WriteLine("The kinds of goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                int goalType = int.Parse(Console.ReadLine());
                Console.Write("What is the name of the goal? ");
                string goalName = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the number of points associated with it? ");
                int pointValue = int.Parse(Console.ReadLine());
                if (goalType == 1)
                {
                    SimpleGoal simpleGoal = new SimpleGoal(goalName, description, points);
                }
                else if (goalType == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal(goalName, description, points);
                }
                else if (goalType == 3)
                {
                    Console.Write("How many times do you want to complete this goal? ");
                    int numberNeeded = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus points when you complete it? ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    ChecklistGoal checklistGoal = new ChecklistGoal(goalName, description, points, numberNeeded, bonusPoints);
                }
                else
                {
                    Console.WriteLine("The number you entered is not a valid choice.");
                    continue;
                }

            }
            else if (choice == 2)
            {
                // List goals
            }
            else if (choice == 3)
            {
                // Save goals
            }
            else if (choice == 4)
            {
                // Load goals
            }
            else if (choice == 5)
            {
                // Record event
            }
            else if (choice == 6)
            {
                // Quit
                remain = false;
            }
            
        }
    }
}