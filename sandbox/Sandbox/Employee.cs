// the parent class showing the "virtual" keyword included
public abstract class Employee
{
    private string _employeeName;

    public Employee(string employeeName)
    {
        _employeeName = employeeName;
    }

    // Notice the abstract method doesn't have a body at all
    // (not even an empty one) and it is followed by a semicolon.
    public abstract float CalculatePay(float hours);
    public string GetEmployeeName()
    {
        return _employeeName;
    }
}


// a child class
public class SalaryEmployee : Employee
{
    private float _salary;

    public SalaryEmployee(string employeeName, float salary) : base(employeeName)
    {
        _salary = salary;
    }

    public override float CalculatePay(float hours)
    {
        return _salary;
    }
}


// a child class
public class HourlyEmployee : Employee
{
    private float _rate;
    private float _hours = 100f;

    public HourlyEmployee(string employeeName, float rate) : base(employeeName)
    {
        _rate = rate;
    }
    public override float CalculatePay(float _hours)
    {
        return _rate * _hours; // pay is calculated differently
    }
}


public class Program
{
    // ...

    // static Employee GetManager()
    // {
    //     // ... code here to find the manager ...
    //     return theManager;
    // }

    // static void DisplayManagerPay()
    // {
    //     Employee manager = GetManager();
    //     float pay = manager.CalculatePay();
    //     // ...
    // }

    public static void Main(string[] args)
    {
        // Create a list of Employees
        List<Employee> employees = new List<Employee>();

        // Create different kinds of employees and add them to the same list
        employees.Add(new SalaryEmployee("Emma Davis", 500));
        employees.Add(new SalaryEmployee("Spencer", 400));
        employees.Add(new HourlyEmployee("Micha Earl", 10.5f));
        employees.Add(new HourlyEmployee("Melanie", 11.25f));
        employees.Add(new SalaryEmployee("Ka", 600));

        // Get a custom calculation for each one
        foreach (Employee employee in employees)
        {
            DisplayPay(employee);
        }
    }

    static void DisplayPay(Employee employee)
    {
            string name = employee.GetEmployeeName();
            Console.Write($"Enter the hours for {name}: ");
            float hours = float.Parse(Console.ReadLine());
            float pay = employee.CalculatePay(hours);
            Console.WriteLine($"{name} {pay}");
    }
}
