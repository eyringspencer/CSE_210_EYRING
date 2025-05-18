using System;


class Program
{
    static void Main(string[] args){
        // instantiate a new object of the Job class
        Job job1 = new Job();

        // job1 company
        job1._company = "Microsoft";

        // job1 title
        job1._jobTitle = "Software Engineer";

        // job1 start year
        job1._startYear = 2005;

        // job1 end year
        job1._endYear = 2020;

        // instantiate job2 object from Job class
        Job job2 = new Job();

        // job2 company
        job2._company = "Apple";

        // job2 title
        job2._jobTitle = "Manager";

        // job2 start year
        job2._startYear = 2010;

        // job2 end year
        job2._endYear = 2013;

        /* Display the company names explicitly
        Console.WriteLine($"{job1._company}");

        Console.WriteLine($"{job2._company}");
        */

        // Call the display method for the job class
        job1.Display();

        job2.Display(); 

        // Instantiate the resume class
        Resume myResume = new Resume();

        // add a name for the resume
        myResume._name = "Mr. Rando Smith";

        // add both job objects to the list of jobs in the resume object
        myResume._jobs.Add(job1);

        myResume._jobs.Add(job2);
        
        /* explicitly display the job titles for verification
        Console.WriteLine($"{myResume._jobs[0]._jobTitle}");

        Console.WriteLine($"{myResume._jobs[1]._jobTitle}");
        */

        // call the display method in the Resume class to display the resume
        myResume.Display();

    }

}

/* this was code that we built together in class before Brother Barzee realized that the instructions told us to put the classes in a seperate file.

class Resume 
{

}


// applicant class
class Applicant 
{
    public string _firstName;

    public string _lastName;

    public string _phoneNumber;

    public string _emailAddress;

    public int _orderOfApplication;

    public int _rank;

    public HttpRequestMessage _resume;

    public void Display(); 
    {

    }
    

}
*/
