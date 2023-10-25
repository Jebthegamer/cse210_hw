public class Assignment
{
    private string _studentName { get; set; }
    private string _topic { get; set; }
    public string GetSummary()
    {
        string summary = $"{_studentName}; {_topic}";
        return summary;
    }
    public string GetStudentName()
    {
        return _studentName;
    }
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
}