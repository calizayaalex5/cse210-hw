using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string action = "";

        Console.WriteLine("Hello World! This is the Journal Project.");
        while (true)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please Select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What do you like to do? ");
            action = Console.ReadLine();

            if (action == "1")
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response: ");
                string _entryText = Console.ReadLine();

                Entry newEntry = new Entry(date, prompt, _entryText);
                myJournal.AddEntry(newEntry);
            }

            else if (action == "2")
            {
                myJournal.DisplayAll();
            }

            else if (action == "3")
            {
                Console.Write("Enter file name to load from: ");
                string file = Console.ReadLine();
                myJournal.LoadToFile(file);
            }

            else if (action == "4")
            {
                Console.Write("Enter file name to save to: ");
                string file = Console.ReadLine();
                myJournal.SaveToFile(file);
            }

            else if (action == "5")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            else
            {
                Console.WriteLine("Invalid Choise");
            }
        }
    }
}