using System.Globalization;

public class Vehicle
{
    // Attributes
    private int _yearManufactured;

    private string _manufacturer;
    private string _modelName;


    // Constructor
    public Vehicle(int yearManufactured, string manufacturer, string modelName)
    {
        _yearManufactured = yearManufactured;

        _manufacturer = manufacturer;

        _modelName = modelName;
    }
}



public class Car : Vehicle
{
    private int _numberOfDoors;

    // Constructor
    public Car(int yearManufactured, string manufacturer, string modelName, int numberOfDoors) : base(yearManufactured, manufacturer, modelName)
    {
        _numberOfDoors = numberOfDoors;
    }
}

public class Ford : Car
{
    public Ford(int yearManufactured, string modelName, int numberOfDoors) : base(yearManufactured, "Ford", modelName, numberOfDoors)
    {

    }
}


public class Program2
{
    public static void Main(string[] args)
    {
        Car car1 = new Car(2006, "Hyundai", "Sonata", 4);

        Ford ford1 = new Ford(2008, "F-150", 2);
        Console.WriteLine
    }
}