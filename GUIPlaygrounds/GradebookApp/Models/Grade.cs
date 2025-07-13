

namespace GradebookApp.Models
{
    public class Grade
    {
        //properties
        public string Subject { get; set; }

        public int Score { get; set; }


        //constructor
        public Grade(string subject, int score)
        {
            Subject = subject;
            Score = score;
        }

        //methods
    }
}