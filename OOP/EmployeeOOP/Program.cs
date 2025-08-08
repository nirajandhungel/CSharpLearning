using System;
public class Program
{
    public static void Main(string[] args)
    {
        Employee emp1 = new Employee(123, "Nirajan Dhungel");
        emp1.DisplayInfo();

        Manager man1 = new Manager(234, "Subash Dhungel", 32);
        man1.DisplayInfo();

    }
}

public class Employee
{
    // fields
    private int id;
    private string name;

    // constructor 
    public Employee(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    // Encapsulatio

    public int GetId()
    {
        return id;
    }

    public string GetName()
    {
        return name;
    }


    public virtual void DisplayInfo()
    {
        Console.WriteLine($"The {id} is associated with {name}.");
    }
}

public class Manager:Employee
{
    public int TeamSize;

    // constructor 
    public Manager(int id, string name, int teamSize): base(id,name)
    {
        this.TeamSize = teamSize;
    }
      public override void DisplayInfo()
    {
        Console.WriteLine($"The  {GetId()} is associated with {GetName()} manager and has time size {TeamSize}.");
    }



}