using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        MathAssignment mathAssignment1 = new MathAssignment("Alex", "Fracion", "Section 7.3", "Problems 8-19");

        Console.WriteLine($"{mathAssignment1.GetSummary()}");
        Console.WriteLine($"{mathAssignment1.GetHomeworkList()}");

        Console.WriteLine();

        WritingAssignment writingAssignment1 = new WritingAssignment("Alex", "European History", "The Causes of World War II by Mary Waters");

        Console.WriteLine($"{writingAssignment1.GetSummary()}");
        Console.WriteLine($"{writingAssignment1.GetWritingInformation()}");


    }
}
   