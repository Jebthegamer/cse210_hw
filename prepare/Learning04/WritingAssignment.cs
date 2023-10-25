public class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string title, string studentName, string topic) : base (studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        string writingInformation = $"{_title} by {studentName}";
        return writingInformation;
    }
}