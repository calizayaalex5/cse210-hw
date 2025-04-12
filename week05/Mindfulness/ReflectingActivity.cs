public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random = new Random();

    public ReflectingActivity(List<string> prompts, List<string> questions)
        : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.", 60)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        Console.Clear();
        Console.Write("How long in seconds would you like for your session? ");
        if (int.TryParse(Console.ReadLine(), out int userDuration))
        {
            _duration = userDuration;
            DisplayStartingMessage();

            Console.WriteLine("\nConsider the following prompt:");
            string prompt = _prompts[_random.Next(_prompts.Count)];
            Console.WriteLine($"--- {prompt} ---");
            Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
            Console.ReadLine();

            Console.WriteLine("\nNow ponder on each of the following questions:");
            ShowSpinner(3);

            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            int questionIndex = 0;

            while (DateTime.Now < endTime)
            {
                string question = _questions[questionIndex % _questions.Count];
                Console.Write($"\n> {question} ");
                ShowSpinner(4);

                questionIndex++;
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