public class Video
{
    public string _tittle;
    public string _author;
    public int _leng;
    public List<Comment> Comments = new List<Comment>();

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public void Display()
    {
        Console.WriteLine($"{_tittle}. By: {_author}");
        Console.WriteLine($"Duration: {_leng} seconds.");
        Console.WriteLine($"comments ({Comments.Count}):");

        foreach (var comment in Comments)
        {
            comment.Display();
        }
    }
}