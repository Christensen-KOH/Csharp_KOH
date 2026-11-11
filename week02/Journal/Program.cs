using System;

// I have added a daily mood tracker (_mood) to the Entry class so the users can record how they felt in their journal response, and persisted this field when saving and loading files.

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                Console.Write("How are you feeling today (e.g., Happy, Grateful, Tired)? ");
                string mood = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = dateText;
                newEntry._promptText = prompt;
                newEntry._entryText = response;
                newEntry._mood = mood;

                theJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                theJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }
        }
    }
}
