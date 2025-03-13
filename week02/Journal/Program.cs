using System;

class Program
{
    static void Main(string[] args)
    {

        int userAction = -1;

        Console.WriteLine("Hello World! This is the Journal Project.");

        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please Select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What do you like to do? ");
        userAction = int.Parse(Console.ReadLine());

    }
}