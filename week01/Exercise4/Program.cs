using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        int number = -1;

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);

        }

        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }

        Console.WriteLine($"The sum is: {sum}");


        float avg = (float)sum / numbers.Count;
        Console.WriteLine($"The avarage is: {avg}");

        int maxNumber = numbers[0];

        foreach (int i in numbers)
        {
            if (i > maxNumber)
            {
                maxNumber = i;
            }
        }

        Console.WriteLine($"The max is: {maxNumber}");
    }
}