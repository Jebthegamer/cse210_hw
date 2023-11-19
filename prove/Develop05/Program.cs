using System;
using System.Diagnostics.Metrics;
class Program
{
    static void Main(string[] args)
    {
        // Initialize variables
        bool remain = true;
        int points = 0;
        int choice;
        List<EternalGoal> goals = new List<EternalGoal>();
        // Print the menu
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
                // Filter based on goal types
                if (goalType == 1)
                {
                    SimpleGoal simpleGoal = new SimpleGoal(goalName, description, pointValue);
                    goals.Add(simpleGoal);
                }
                else if (goalType == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal(goalName, description, pointValue);
                    goals.Add(eternalGoal);
                }
                else if (goalType == 3)
                {
                    Console.Write("How many times do you want to complete this goal? ");
                    int numberNeeded = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus points when you complete it? ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    ChecklistGoal checklistGoal = new ChecklistGoal(goalName, description, pointValue, numberNeeded, bonusPoints);
                    goals.Add(checklistGoal);
                }
                else
                {
                    Console.WriteLine("The number you entered is not a valid choice.");
                }

            }
            else if (choice == 2)
            {
                int counter = 1;
                // List goals by printing them individually
                foreach (EternalGoal goal in goals)
                {
                    goal.DisplayGoal(counter);
                    counter++;
                }
            }
            else if (choice == 3)
            {
                // Save goals
                Console.Write("What is the name of the file you would like to save to? ");
                string fileName = Console.ReadLine();
                // Clear the file's previous contents, print the points.
                using (StreamWriter outputFile = File.CreateText(fileName))
                {
                    outputFile.WriteLine($"{points}");
                }
                // Print the goals.
                foreach (EternalGoal goal in goals)
                {
                    using (StreamWriter outputFile = File.AppendText(fileName))
                    {
                        outputFile.WriteLine(goal.GetSaveString());
                    }
                }
            }
            else if (choice == 4)
            {
                // Load goals
                Console.Write("What is the name of the file you would like to load information from? ");
                string fileName = Console.ReadLine();
                // If the file exists, load the goals. Otherwise print the error message.
                if (File.Exists(fileName))
                {
                    EternalGoal eternalGoal = new("", "", 0);
                    ChecklistGoal checklistGoal = new("", "", 0, 0, 0);
                    SimpleGoal simpleGoal = new("", "", 0);
                    string[] lines = System.IO.File.ReadAllLines(fileName);
                    foreach (string words in lines)
                    {
                        // If the line is associated with a goal, create the goal. Otherwise, set the points to the value.
                        string[] strings = words.Split(",");
                        if (strings[0] == "EternalGoal")
                        {
                            eternalGoal = eternalGoal.DecodeSaveString(words);
                            goals.Add(eternalGoal);
                        }
                        else if (strings[0] == "ChecklistGoal")
                        {
                            checklistGoal = checklistGoal.DecodeSaveString(words);
                            goals.Add(checklistGoal);
                        }
                        else if (strings[0] == "SimpleGoal")
                        {
                            simpleGoal = simpleGoal.DecodeSaveString(words);
                            goals.Add(simpleGoal);
                        }
                        else
                        {
                            points = int.Parse(words);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("The file you are trying to load from doesn't exist.");
                }
            }
            else if (choice == 5)
            {
                // Record event
                Console.WriteLine("The goals are:");
                int counter = 1;
                foreach (EternalGoal goal in goals)
                {
                    goal.DisplayGoal(counter);
                    counter++;
                }
                Console.Write("Which goal did you accomplish? ");
                int goalChoice = int.Parse(Console.ReadLine());
                points += goals[goalChoice-1].CompleteGoal();
            }
            else if (choice == 6)
            {
                // Quit
                remain = false;
            }            
        }
    }
}