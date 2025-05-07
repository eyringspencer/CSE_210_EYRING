public class Job {
    public string _company;
    public string _jobTitle;

    public int _startYear;

    public int _endYear;

    // create a display method
    //NOTE: True methods have direct access to the attributes because we use an object to call the method. In other words, the object is the first argument passed to the method.
    public void Display(){
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    } 
}