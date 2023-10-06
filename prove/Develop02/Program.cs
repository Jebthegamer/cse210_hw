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
        */
        Journal journal = new Journal();
        Journal old_entries = new Journal();
        bool continueLoop = true;
        while (continueLoop)
        {
            string[] questions = System.IO.File.ReadAllLines("Prompts.txt");
            List<string> prompts = new List<string>();
            foreach (string prompt in questions)
            {
                prompts.Add(prompt);
            }
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Which would you like to do? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                var random = new Random();
                int index = random.Next(prompts.Count);
                string prompt = prompts[index];
                Entry entry = new Entry();
                entry = entry.WriteEntry(prompt);
                journal.Entries.Add(entry);
            }
            else if (choice == "2")
            {
                foreach (Entry entry in old_entries.Entries)
                {
                    Console.WriteLine($"{entry.datePrompt}");
                    Console.WriteLine($"{entry.response}");
                    Console.WriteLine("");
                }
                foreach (Entry entry in journal.Entries)
                {
                    Console.WriteLine($"{entry.datePrompt}");
                    Console.WriteLine($"{entry.response}");
                    Console.WriteLine("");
                }
            }
            else if (choice == "3")
            {
                Console.WriteLine("Please enter the name of the file you wish to load.");
                string fileName = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(fileName);
                int count = 0;
                Entry entry = new Entry();
                old_entries = new Journal();
                foreach (string line in lines)
                {
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
                journal = new Journal();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Where do you want to save this file to?");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                int count = 0;
                Entry entry1 = new Entry();
                old_entries = new Journal();
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
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (Entry entry in old_entries.Entries)
                    {
                        outputFile.WriteLine($"{entry.datePrompt}");
                        outputFile.WriteLine($"{entry.response}");
                    }
                    foreach (Entry entry in journal.Entries)
                    {
                        outputFile.WriteLine($"{entry.datePrompt}");
                        outputFile.WriteLine($"{entry.response}");
                    }
                    count = 0;
                    foreach (Entry entry in journal.Entries)
                    {
                        int length = journal.Entries.Count();
                        old_entries.Entries.Add(journal.Entries[count]);
                        count ++;
                    }
                    journal = new Journal();
                }
            }
            else if (choice == "5")
            {
                continueLoop = false;
            }
            else if (choice == "6")
            {
                Console.WriteLine("Enter your new prompt.");
                string newPrompt = Console.ReadLine();
                prompts.Add(newPrompt);
                using (StreamWriter outputFile = new StreamWriter("Prompts.txt"))
                {
                    foreach (string prompt in prompts)
                    {
                        outputFile.WriteLine($"{prompt}");
                    }
                }
            }
        }
    }
}