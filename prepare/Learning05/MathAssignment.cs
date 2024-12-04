class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        // the math assignment specific variables go here but
        // hey i called base up there and now this constructor knows
        // studentname and topic too :)
        _textbookSection = textbookSection;
        _problems = problems;
    }
    // "If a base class doesn't offer a parameterless constructor, the derived class must make an explicit call to a base constructor by using base ."
    // googled a thing because i need to remember why thing :)

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }

}