



using System.Collections.ObjectModel;

namespace GradebookApp.Models
{
    public class Student
    {
        //properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{LastName}, {FirstName}";

        public ObservableCollection<Grade> Grades { get; set; } = new();

        
        //constructor
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        




        //methods

    }
}

