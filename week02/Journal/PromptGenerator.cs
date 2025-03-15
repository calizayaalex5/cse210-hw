using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
        public List<string> _promptText;
        public Random _random;

        public PromptGenerator()
        {
            _promptText = new List<string>
            {
            "What did you to do today?",
            "What new thing that your learned today?",
            "What's a thing that makes you happy today?",
            "How can you fix the problems that you had today?",
            "How is your family?",
            ""
            };

            _random = new Random();
        }

        public string GetRandomPrompt()
        {
            int index = _random.Next(_promptText.Count);
            return _promptText[index];
        }
        public void Display()
        {
            Console.WriteLine(GetRandomPrompt());
        }
        

}