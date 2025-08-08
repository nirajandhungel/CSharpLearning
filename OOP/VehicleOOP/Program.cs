using System;
public class Program
{
    public static void Main(string [] args)
    {
        Vehicle RegularVehicle = new Vehicle("Toyota", "Corolla", 2020);
        RegularVehicle.Start();  
        Vehicle ev = new ElectricVehicle("Tesla", "Model 3", 2025,65);
        ev.Start();  
    }

}
//Base Class
public class Vehicle
{
    // Private Fields -- Encapsulation
    private string make;
    private string model;
    private int year;

    // constructor
    public Vehicle(string make, string model, int year)
    {
        this.make = make;
        this.model = model;
        this.year = year;
    }

    // Getters
    public string GetMake()
    {
        return make;
    }
    public string GetModel()
    {
        return model;
    }
    public int GetYear()
    {
        return year;
    }
    public virtual void Start()
    {
        Console.WriteLine($"Staring the {make} {model} {year}.");
    }

}

public class ElectricVehicle : Vehicle
{
    // Private Field -- Encaps
    private int batteryCapacity;
    //constructor 
    public ElectricVehicle(string make, string model, int year, int batteryCapacity) : base(make, model, year)
    {
        this.batteryCapacity = batteryCapacity;
    }

    //property
    public int GetBatteryCapacity()
    {
        return batteryCapacity;
    }
    public override void Start()
    {
        Console.WriteLine($"Starting the electric {GetMake()} {GetModel()} {GetYear()} with battery capacity {batteryCapacity} kwh");
   
    }

}