using System;

class Program
{
        static void Main(string[] args)
        {
    
            DisplayWelcomeMessage();

            string userName = GetPromptUserName();
            int userNumber = GetPromptUserNumber();

            int square = calculateSquareNumber(userNumber);

            DisplayResult(userName, square);
        }

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string GetPromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int GetPromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favoriteNumer = int.Parse(Console.ReadLine());

            return favoriteNumer;
        }

        static int calculateSquareNumber(int favoriteNumer)
        {
            int square = favoriteNumer * favoriteNumer;
            return square;
        }

        static void DisplayResult (string name, int square)
        {
            Console.WriteLine($"{name}, the square of you number is {square}");
        }

    
}