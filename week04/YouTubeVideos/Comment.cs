public class Comment
{
    public string _user;
    public string _comment;

    public Comment(string user, string comment)
    {
        _user = user;
        _comment = comment;
    }

    public void Display()
    {
        Console.WriteLine($"{_user}: {_comment}");
    }
}