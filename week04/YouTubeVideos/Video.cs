using System.Transactions;

public class Video
{
    public string Title { get; set;}
    public string Author { get; set;}
    public int LengthInSeconds { get; set;}

    private List<Comment> comments = new List<Comment>();
    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthInSeconds}");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");

        foreach (Comment comment in comments)
        {
            comment.Display();
        }

        Console.WriteLine();
    }
}