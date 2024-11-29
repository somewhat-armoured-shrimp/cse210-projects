class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void Add(Comment comment)
    {
        _comments.Add(comment);
    }
    public int CountComments()
    {   
        return _comments.Count();
    }
    public string GetDisplayText()
    {
        string text = $"{_title} - by {_author} | Length: {_length}s\nNumber of comments: {CountComments()}";

        foreach (Comment comment in _comments)
        {
            text = $"{text}\n{comment.GetDisplayText()}";
        }
        return $"{text}\n";
    }
}