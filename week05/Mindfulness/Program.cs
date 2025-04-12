using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Hello World! This is the Mindfulness Project.\n");

            Console.WriteLine("Menu Options");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");

            Console.Write("\nSelect a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine();
            }
            else if (choice == "2")
            {
                List<string> reflectPrompts = new List<string>
                {
                    "Think of a time when you overcame a challenge.",
                    "Recall a moment when you helped someone in need.",
                    "Think about a time when you did something truly difficult."
                };

                List<string> reflectQuestions = new List<string>
                {
                    "Why was this experience meaningful to you?",
                    "What did you learn about yourself?",
                    "How did you feel when it was complete?",
                    "What is your favorite part about this experience?",
                    "How can you apply what you learned to future situations?"
                };

                ReflectingActivity reflecting = new ReflectingActivity(reflectPrompts, reflectQuestions);
                reflecting.Run();
                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine();
            }
            else if (choice == "3")
            {
                List<string> listingPrompts = new List<string>
                {
                    "Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "Who are people that you have helped this week?",
                    "When have you felt the Holy Ghost this month?",
                    "Who are some of your personal heroes?"
                };

                ListingActivity listing = new ListingActivity(0, listingPrompts);
                listing.Run();
                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine();
            }
            else if (choice == "4")
            {
                Console.WriteLine("\nThank you for using the Mindfulness Program. Goodbye!");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("\nInvalid choice. Please try again.");
                Thread.Sleep(2000);
            }
        }
    }
}