using System;
using Obj;
public class Program
{
    public static void Main(string[] args)
    {
        Car regularCar = new Car("Toyota", 1993, "ENG098765432");
        regularCar.Start();
        ;

        SuperCar ferrari = new SuperCar("Ferrari", 2025, "ENG1234567890", true);
        ferrari.Start();
        ferrari.TurboBoost();
        SuperCar ferrari2 = new SuperCar("Ferrari2", 2020, "ENG456378290", false);
        ferrari2.Start();
        ferrari2.TurboBoost();
    }
}
