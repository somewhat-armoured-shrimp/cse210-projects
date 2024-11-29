class Comment
{
    private string _commentor;
    private string _comment;

    public Comment(string commentor, string comment)
    {
        _commentor = commentor;
        _comment = comment;
    }

    public string GetDisplayText()
    {   
        return $"{_commentor} commented: '{_comment}'";
    }
}