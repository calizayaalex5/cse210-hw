public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private List<string> _responses = new List<string>();
    private Random _random = new Random();

    public ListingActivity(int count, List<string> prompts)
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by listing as many as you can.", 60)
    {
        _count = count;
        _prompts = prompts;
    }

    public void Run()
    {
        Console.Clear();
        Console.Write("How long in seconds would you like for your session? ");
        if (int.TryParse(Console.ReadLine(), out int userDuration))
        {
            _duration = userDuration;
            DisplayStartingMessage();

            string prompt = _prompts[_random.Next(_prompts.Count)];
            Console.WriteLine($"\nList as many responses as you can to the following prompt:");
            Console.WriteLine($"--- {prompt} ---");

            Console.WriteLine("\nYou may begin in:");
            ShowCountDown(5);

            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    _responses.Add(input);
                    _count++;
                }
            }

            Console.WriteLine($"\nYou listed {_count} items.");
            DisplayEndingMessage();
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            ShowSpinner(2);
        }
    }
}