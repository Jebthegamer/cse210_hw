using System;
using System.IO;

class Program
{

    static void Main(string[] args)
    {
        // Initialize journals and the continue loop.
        Journal journal = new Journal();
        bool continueLoop = true;
        while (continueLoop)
        {
            // Create the prompt list by reading "Prompts.txt"
            string[] questions = System.IO.File.ReadAllLines("Prompts.txt");
            List<string> prompts = new List<string>();
            foreach (string prompt in questions)
            {
                prompts.Add(prompt);
            }
            // Print the menu, not including the hidden option to create new prompts.
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Which would you like to do? ");
            string choice = Console.ReadLine();
            // If writing a new entry, go to this option.
            if (choice == "1")
            {
                // Select a random prompt.
                var random = new Random();
                int index = random.Next(prompts.Count);
                string prompt = prompts[index];

                // Initialize an entry. Add the prompt to it, write the response and store in journal.
                Entry entry = new Entry();
                entry = entry.WriteEntry(prompt);
                journal.Entries.Add(entry);
            }
            // Go to this section if displaying entries.
            else if (choice == "2")
            {
                journal.DisplayJournal();
            }
            // If loading go here.
            else if (choice == "3")
            {
                // Get user input, open file.
                Console.WriteLine("Please enter the name of the file you wish to load.");
                string fileName = Console.ReadLine();
                journal = new Journal();
                journal.ReadFile(fileName);
            }
            // If saving, go here.
            else if (choice == "4")
            {
                // Get user input, open the file.
                Console.WriteLine("Where do you want to save this file to?");
                string fileName = Console.ReadLine();
                
                journal.WriteFile(fileName, journal);
            }
            // If quitting, end the loop.
            else if (choice == "5")
            {
                continueLoop = false;
            }
            // If adding a prompt, go here.
            else if (choice == "6")
            {
                // As for input, open prompts file
                Console.WriteLine("Enter your new prompt.");
                string newPrompt = Console.ReadLine();

                // Add the new prompt to the list
                prompts.Add(newPrompt);
                using (StreamWriter outputFile = new StreamWriter("Prompts.txt"))
                {
                    // Print all of the prompts into "Prompts.txt"
                    foreach (string prompt in prompts)
                    {
                        outputFile.WriteLine($"{prompt}");
                    }
                }
                // The reason why I didn't use the above logic for the journals is because I wanted it to be possible to add 
                // the new entries of the journal into a separate file than the one that was loaded.
                // I exceeded requirements by adding a hidden 6th feature; adding prompts to the list. These added prompts are
                // added to the "Prompts.txt" file, which allows them to be used when starting up the program in future instances.
            }
        }
    }
}