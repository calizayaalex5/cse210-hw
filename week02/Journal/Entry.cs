public class Entry
{
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }

    public Entry(string date, string promptText, string entryText)
    {
        Date = date;               
        PromptText = promptText;    
        EntryText = entryText;      
    }
    public void Display()
    {
        Console.WriteLine($"{PromptText}");
        Console.WriteLine($"{Date}: {EntryText}");
    }
}