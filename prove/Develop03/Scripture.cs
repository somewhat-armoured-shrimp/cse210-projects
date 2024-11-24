public class Scripture
{
    // private string _scripture;
    private List<Word> _word = new List<Word>();
    private Reference _reference;

    public void HideRandomWords(int numberToHide)
    {
        // shuffles the words list after turning it into an array
        // and then hides the first three items of that shuffled array ooooooh an illusion
        Random random = new Random();
        Word[] words = _word.ToArray(); // shuffling Lists is not permitted :(
        random.Shuffle(words); // https://learn.microsoft.com/en-us/dotnet/api/system.random.shuffle?view=net-9.0

        int numberHidden = 0;
        // actually hides the words AND keeps track of whether
        // or not a word is hidden
        foreach (Word word in words)
        {
            if (!word.IsHidden())
            {
                word.Hide();
                numberHidden++; 
            }

            if (numberHidden == numberToHide)
            {
                break;
            }
        }
    }
    public string GetDisplayText()
    {
        string verse = _reference.GetDisplayText();

        foreach (Word word in _word)
        {
            verse = verse + " " + word.GetDisplayText();
        }
        return verse;
    }
    public bool IsCompletelyHidden()
    {   
        foreach (Word word in _word)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public Scripture(Reference reference, string text)
    {
        string[] words = text.Split(" ");
        _reference = reference;

        foreach (string txt in words)
        {
            Word w = new Word(txt);

            _word.Add(w);

        }
    }
}