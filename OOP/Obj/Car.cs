using System;
namespace Obj
{
    public class Car
    {
        // public properties with controlled access
        public string Model { get; set; }
        public int Year { get; set; }

        // private prop  hidden from outside
        private string engineNumber;

        // constructor to initialize object

        public Car(string model, int year, string engineNumber)
        {
            Model = model;
            Year = year;
            this.engineNumber = engineNumber; // private field set inside class

        }

        // public method / behaviour
        public virtual void Start()
        {
            Console.WriteLine($"{Model} Car is starting");
        }

        // protected method 
        protected void ShowNumber()
        {
            Console.WriteLine($"{engineNumber} is the number of {Model} car");
        }

    }
}