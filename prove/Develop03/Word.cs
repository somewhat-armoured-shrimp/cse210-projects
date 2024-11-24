public class Word
{
    private string _text;
    private bool _isHidden = false;

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string hiddenString = new string('_', _text.Length);
            return hiddenString;
        }
        else
        {
            return _text;
        }

    }

    public Word(string text)
    {
        _text = text;
    }
}