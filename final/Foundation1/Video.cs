public class Video
{
    private string title;
    private string author;
    private int lengthInSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        this.title = title;
        this.author = author;
        this.lengthInSeconds = lengthInSeconds;
        this._comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public int LengthInSeconds
    {
        get { return lengthInSeconds; }
        set { lengthInSeconds = value; }
    }

    public List<Comment> Comments
    {
        get { return _comments; }
    }
}