namespace Foundation1;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void Display()
    {
        int hours = _length / 3600;
        int minutes = (_length % 3600) / 60;
        int seconds = (_length % 3600) % 60;
        string upperTitle = _title.ToUpper();
        
        Console.WriteLine($"Title: {upperTitle}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length (hh:mm:ss): {hours:D2}:{minutes:D2}:{seconds:D2}");
        Console.WriteLine($"Number of Comments: {NumComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment c in _comments)
        {
            c.Display();
        }
    }

    public void AddComment(string name, string text)
    {
        Comment newComment = new Comment(name, text);
        _comments.Add(newComment);
    }
    
    public int NumComments()
    {
        int numberOfComments = _comments.Count;
        return numberOfComments;
    }
}