using System;

public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    public List<Comment> comment = new List<Comment>();

    public void displayVideo()
    {
        int commentCount = 0;
        int x = 1;
        Console.WriteLine("\n-----------------------------");
        Console.WriteLine($"\nTitle: {_title}\nAuthor: {_author}" +
        $"\nDuration: {_lengthInSeconds} seconds");
        Console.WriteLine("\n-----------------------------");
        foreach (Comment comments in comment)
        {
            commentCount += 1;
        }
        Console.WriteLine($"         {commentCount} comments ");
        Console.WriteLine("-----------------------------");
        foreach (Comment comments in comment)
        {
            Console.Write($"\n{comments.dipalyComment(comments)}");
            x++;
        }
    }
}