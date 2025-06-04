///<summary>
/// This will be a parent class that includes generic traits of any assignemnt
///</summary>


public class Assignment
{
    // Attributes
    private string _studentName;

    private string _topic;

    // Constructor

    // default
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;

        _topic = topic;
    }

    // Methods

    // Get summary should return a string that has student name and topic
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // get the student name
    public string GetStudentName()
    {
        return _studentName;
    }
}