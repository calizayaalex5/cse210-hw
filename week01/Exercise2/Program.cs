using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("How many points have? ");
        string points = Console.ReadLine();
        int grade = int.Parse(points);

        string gradeLetter = "";

        if (grade >= 90)
        {
            gradeLetter = "A";
        }

        else if (grade >= 87)
        {
            gradeLetter = "B+";
        }

        else if (grade >= 80)
        {
            gradeLetter = "B";
        }

        else if (grade >= 70)
        {
            gradeLetter = "C";
        }

        else if (grade >= 60)
        {
            gradeLetter = "D";
        }

        if (grade < 60)
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"Your grade is {gradeLetter}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }

        else
        {
            Console.WriteLine("Try Again.");
        }
    }
}