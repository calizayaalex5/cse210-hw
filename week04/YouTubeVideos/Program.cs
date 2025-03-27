using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video();

        video1._tittle = "I bought 10000000 dollars in Lego sets";
        video1._author = "Mr. Beast";
        video1._leng = 450;

        Video video2 = new Video();

        video2._tittle = "What is Python?";
        video2._author = "Nate Gentile";
        video2._leng = 1200;

        Video video3 = new Video();

        video3._tittle = "I paint my new houe!";
        video3._author = "JAWX";
        video3._leng = 450;

        Comment comment1 = new Comment("Mike123hello", "I love you video!");
        Comment comment2 = new Comment("Trollingboy", "That was crazy bro!");
        Comment comment3 = new Comment("Michael102", "First comment");

        Comment comment4 = new Comment("Anonimous12", "You are the best");
        Comment comment5 = new Comment("Aletro54", "Today I learnd something new");
        Comment comment6 = new Comment("DawsonGardenLOL", "Wow! This is so interesting");

        Comment comment7 = new Comment("Imagination22", "Your work is beautiful!!!");
        Comment comment8 = new Comment("Javierx23", "can you paint my house?");
        Comment comment9 = new Comment("Stich", "WOW");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        video1.Display();
        Console.WriteLine();
        video2.Display();
        Console.WriteLine();
        video3.Display();
  

    }
}