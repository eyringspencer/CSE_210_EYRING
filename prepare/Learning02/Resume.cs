
// CREATE THE RESUME CLASS
public class Resume {
    //declare a variable to store the person's name
    public string _name; 

    //instantiate a new Job object to hold a new list before we use it
    public List<Job> _jobs = new List<Job>();

    // create a display method that shows the name first followed by each one of the jobs
    public void Display(){
        // print the name from the resume class
        Console.WriteLine($"Name: {_name}");

        // print the header for the jobs list
        Console.WriteLine("Jobs:");

        // loop through each job 
        foreach (Job job in _jobs){
            //call the display method from the jobs class
            job.Display();
        }
    }

}