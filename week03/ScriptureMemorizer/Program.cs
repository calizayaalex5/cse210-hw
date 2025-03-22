using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("Alma", 32, 42);

        string passage = "And because of your diligence and your faith and your patience with the word in nourishing it, that it may take root in you, behold, by and by ye shall pluck the fruit thereof, which is most precious, which is sweet above all that is sweet, and which is white above all that is white, yea, and pure above all that is pure; and ye shall feast upon this fruit even until ye are filled, that ye hunger not, neither shall ye thirst.";
        Scripture scripture = new Scripture(reference, passage);

        Console.WriteLine("Your scripture:");
        Console.WriteLine(scripture.GetDisplayText());

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Press ENTER to hide words, or type 'quit' to exit.");
            string input = Console.ReadLine().Trim().ToLower();

            if (input.Trim().ToLower() == "quit")
                break;


            scripture.HideRandomWords(5);
            Console.WriteLine("Updating scripture");
            Console.WriteLine(scripture.GetDisplayText());
        }


    }
}