
class Video
{
    private string _title;

    private string _author;

    private float _length;

    private List<Comment> _comments;

    public Video(string title, string author, float length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public static void DisplayVideos(Video video)
    {
        Console.Write("Title: ");
        Console.WriteLine(video._title);
        Console.Write("Author: ");
        Console.WriteLine(video._author);
        Console.Write("Length(s): ");
        Console.WriteLine(video._length);
        Console.Write("Number of Comments: ");
        Console.WriteLine(NumComments(video._comments));
        Console.WriteLine("Comments:");
        foreach (Comment comment in video._comments)
        {
            Comment.DisplayComment(comment);
        }

    }

    public static int NumComments(List<Comment> comments)
    {
        int num = comments.Count;
        return num;
    }
}