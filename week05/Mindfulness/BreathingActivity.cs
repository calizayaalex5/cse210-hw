public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing.", 60)
    {
    }   
    public void Run()
{
    DisplayStartingMessage();

    Console.Write("How long in seconds would you like for your session? ");
    if (int.TryParse(Console.ReadLine(), out int userDuration))
    {
        _duration = userDuration;

        for (int i = 0; i < _duration / 10; i++)
        {
            Console.Write("\nBreathe in... ");
            ShowCountDown(4);

            Console.Write("\nNow breathe out... ");
            ShowCountDown(6);
        }

        DisplayEndingMessage();
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number.");
        ShowSpinner(2);
    }
}
}