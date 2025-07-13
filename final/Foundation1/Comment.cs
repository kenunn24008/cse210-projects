class Comment
{
    private string _name;

    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public static void DisplayComment(Comment comment)
    {
        Console.Write("Name: ");
        Console.WriteLine(comment._name);
        Console.Write("Comment: ");
        Console.WriteLine(comment._text);
        Console.WriteLine();

    }
}