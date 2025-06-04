///<summary>
/// Child class of Assignment
/// includes detaisl of textbook section and problems
/// Can return a string of the homework list
/// </summary.

public class MathAssignment : Assignment
{
    // Attributes
    private string _textbookSection;

    private string _problems;

    // Constructor

    // default
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;

        _problems = problems;

    }

    // Methods

    // method to get a string of the homework assigned
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} - Problems {_problems}";
    }
}