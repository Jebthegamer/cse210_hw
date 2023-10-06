using System;
using System.IO;

class Program
{

    static void Main(string[] args)
    {
        // Initialize variables
        
        
        /* Start loop
            Display the menu
            Ask which option the user should do
                1: Write an entry
                    1A: Display the prompt
                    1B: Ask for user input
                        1AA: Store the date, prompt, and response in an entry
                2:  Display the entries
                    2A: Retrieve the journal's entry list
                    2B: Print the list, including the prompt, date, and response.
                        2AA: For loop, going through the entries in the entry list contained in Journal class
                3: Load
                    3A: Read a file
                        3AA: Read each line, store as entries. Every other line will be a date/prompt then an entry
                        3AB: While loop; or for lines in file store one line as the first part of an entry; then the next line as
                            another part of the entry.
                4: Save file
                    4A: Print entries from journal onto the file
                5: Quit
                    5A: End while loop; close files (if needed), end program.
                6: Create new prompt.
        */

        // Initialize journals and the continue loop.
        Journal journal = new Journal();
        Journal old_entries = new Journal();
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

                // Print the loaded entries.
                foreach (Entry entry in old_entries.Entries)
                {
                    Console.WriteLine($"{entry.datePrompt}");
                    Console.WriteLine($"{entry.response}");
                    Console.WriteLine("");
                }
                // Print the new entries.
                foreach (Entry entry in journal.Entries)
                {
                    Console.WriteLine($"{entry.datePrompt}");
                    Console.WriteLine($"{entry.response}");
                    Console.WriteLine("");
                }
            }
            // If loading go here.
            else if (choice == "3")
            {
                // Get user input, open file.
                Console.WriteLine("Please enter the name of the file you wish to load.");
                string fileName = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(fileName);
                int count = 0;
                // Initialize a new entry; clear previously loaded entries.
                Entry entry = new Entry();
                old_entries = new Journal();
                foreach (string line in lines)
                {
                    // Every other line is a date+prompt and a response. Therefore, every other line a new entry must be made
                    // and every other line it is added to the old_entries journal.
                    if (count % 2 == 0)
                    {
                        entry = new Entry();
                        entry.datePrompt = line;
                    }
                    else
                    {
                        entry.response = line;
                    }
                    if (count % 2 == 1)
                    {
                        old_entries.Entries.Add(entry);
                    }
                    count ++;
                }
                // Clear journal to prevent multiple instances of entries from showing up.
                journal = new Journal();
            }
            // If saving, go here.
            else if (choice == "4")
            {
                // Get user input, open the file.
                Console.WriteLine("Where do you want to save this file to?");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                int count = 0;
                // Clear old entries
                Entry entry1 = new Entry();
                old_entries = new Journal();
                // This is reused code from loading the file, as we need to load the file's previous entries to add onto it.
                foreach (string line in lines)
                {
                    if (count % 2 == 0)
                    {
                        entry1 = new Entry();
                        entry1.datePrompt = line;
                    }
                    else
                    {
                        entry1.response = line;
                    }
                    if (count % 2 == 1)
                    {
                        old_entries.Entries.Add(entry1);
                    }
                    count ++;
                }
                // Notably clearing journal is not here because we are going to be using it.
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    // Put the old entries back into the journal
                    foreach (Entry entry in old_entries.Entries)
                    {
                        outputFile.WriteLine($"{entry.datePrompt}");
                        outputFile.WriteLine($"{entry.response}");
                    }
                    // Add the new ones
                    foreach (Entry entry in journal.Entries)
                    {
                        outputFile.WriteLine($"{entry.datePrompt}");
                        outputFile.WriteLine($"{entry.response}");
                    }
                    count = 0;
                    // Next, we set the old_entries to contain the new ones, as the loaded file now has both sets of entries.
                    foreach (Entry entry in journal.Entries)
                    {
                        int length = journal.Entries.Count();
                        old_entries.Entries.Add(journal.Entries[count]);
                        count ++;
                    }
                    // Clear journal again; the entries are contained in old_entries.
                    journal = new Journal();
                }
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
                //the new entries of the journal into a separate file than the one that was loaded.
                // I exceeded requirements by adding a hidden 6th feature; adding prompts to the list. These added prompts are
                // added to the "Prompts.txt" file, which allows them to be used when starting up the program in future instances.
            }
        }
    }
}