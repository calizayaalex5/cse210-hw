using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("None entry");
        }

        foreach (var entry in _entries)
        {
            entry.Display();
            Console.WriteLine(); 
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry.Date} | {entry.PromptText} | {entry.EntryText}");
            }
        }
        Console.WriteLine($"Journal saved to {file}");
    }

    public void LoadToFile(string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);
            foreach (var line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry(parts[0].Trim(), parts[1].Trim(), parts[2].Trim());
                    _entries.Add(entry);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found");
        }

    }
}