class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {   
        // oh nice i dont even have to say base.GetStudentName()
        // to call it, it can just be GetStudentName();
        string studentName = GetStudentName();
        
        return $"{_title} by {studentName}";
    }
}