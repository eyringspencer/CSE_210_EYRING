///<summary>
/// Child class of Assignment
/// Includes details of the title of the assignment
/// returns the title information
/// </summary>

public class WritingAssignment : Assignment
{
    // Attributes

    private string _title;

    // Constructors

    // default
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // Methods

    //get a string of writing assignment information
    public string GetWritingInformation()
    {
        // call the get student name method because _studentName is private in the assignment class
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}