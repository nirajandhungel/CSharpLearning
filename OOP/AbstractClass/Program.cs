using System;
public class Program
{
    public static void Main(string[] args)
    {
        Car car1 = new Car("Toyota", "Corolla",2025, "Diesel");
        car1.Start(); 
        car1.Drive();
        EV ev1 = new EV("Tesla", "Model 3", 2025, 88);
        ev1.Start();
        ev1.Drive(); 

    }
}
public interface IDriveable
{
    void Drive();
}

public abstract class Vehicle 
{
    // private fields , encaps
    private string _make;
    protected string model;
    public int Year { get; set; }

    // Constructor to initialize the objects
    public Vehicle(string make, string model, int year)
    {
        this._make = make;
        this.model = model;
        Year = year;
    }

    public string GetMake()
    {
        return _make;
    }
    public string GetModel()
    {
        return model;
    }

    //properties 

    public abstract void Start();
}

public class Car : Vehicle, IDriveable
{
    private string FuelType;
    public Car(string make, string model, int year, string fuelType) : base(make, model, year)
    {
        this.FuelType = fuelType;
    }
    public override void Start()
    {
        Console.WriteLine($"Starting {GetMake()} {GetModel()} {Year} {FuelType}");
    }
    public void Drive() {
        Console.WriteLine($"The {GetMake()} {GetModel()} {Year} is being drove ");
    }
    
}
public class EV : Vehicle, IDriveable
{
    public  int BatteryCapacity { get; set; }
    public EV(string make, string model, int year, int batteryCapacity) : base(make, model, year)
    {
        this.BatteryCapacity = batteryCapacity;
    }
    public override void Start()
    {
        Console.WriteLine($"Starting {GetMake()} {GetModel()} {Year} {BatteryCapacity} Kwv");
    }
    public void Drive() {
        Console.WriteLine($"The {GetMake()} {GetModel()} {Year} is being silently  drove ");
    }
    
}