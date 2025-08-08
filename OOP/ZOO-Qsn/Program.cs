using System;

//Entry Point
public class Program
{
    //Main Function
    public static void Main(string[] args)
    {
        // Object of Lion
        Lion Simbha = new Lion("Simbha", "Lion", 12, "Gray");
        Simbha.Feed();
        Simbha.MakeSound();
        Simbha.Move();

        // Object of Elephant
        Elephant Dumbo = new Elephant("Dumbo", "Elephant", 19, 1.2);
        Dumbo.Feed();
        Dumbo.MakeSound();
        Dumbo.Move();

        // Object of Parrot Class
        Parrot Rio = new Parrot("Rio", "Parrot", 1, true);
        Rio.Feed();
        Rio.MakeSound();
        Rio.Move();

    }

}

// Inteface to define a behaviour
public interface IFeedable
{
    // behaviour contract
    void Feed();
}

// Abstract Class Animal
public abstract class Animal
{
    // fields/ props
    private string _name; // encapsulation using private field
    protected string species;// encapsulation using protected field
    public int Age { get; set; }

    //constructor to initialize objects
    public Animal(string name, string species, int age)
    {
        this._name = name;
        this.species = species;
        this.Age = age;
    }

    //getters for encapsulated fields 

    public string GetName()
    {
        return _name;
    }

    // behaviours functions
    public abstract void MakeSound();
    public abstract void Move();
}

public class Lion : Animal, IFeedable
{

    // Fields 
    public string FurColor{ get; set; }

    //constructor
    public Lion(string name, string species, int age, string furColor) : base(name, species, age)
    {
        this.FurColor = furColor;
    }
    public void Feed()
    {
        Console.WriteLine($"Feeding {GetName()}");
    }
    public override void Move()
    {
        Console.WriteLine($" {GetName()} the {species} of fur color {FurColor} roars  and walks swiftly ");
    }
    public override void MakeSound()
    {
        Console.WriteLine($"{GetName()} the {species} of age {Age} is Roaring");
    }

}

public class Elephant : Animal, IFeedable
{

    // Fields 
    private double _trunkLength;

    //constructor
    public Elephant(string name, string species, int age, double trunkLength) : base(name, species, age)
    {
        this._trunkLength = trunkLength;
    }

    public double GetTrunkLength()
    {
        return _trunkLength;
    }

    public void Feed()
    {
        Console.WriteLine($"Feeding {GetName()}");
    }
    public override void Move()
    {
        Console.WriteLine($" {GetName()} the {species} of trunk length {_trunkLength}m trumpets  and walks heavily ");
    }
    public override void MakeSound()
    {
        Console.WriteLine($"{GetName()} the {species} of age {Age} is trumpeting loudly");
    }

}

public class Parrot : Animal, IFeedable
{

    // Fields 
    public bool CanTalk { get; set; }

    //constructor
    public Parrot(string name, string species, int age, bool canTalk) : base(name, species, age)
    {
        this.CanTalk = canTalk;
    }
    public  void Feed()
    {
        Console.WriteLine($"Feeding {GetName()}");
    }
    public override void Move()
    {
        Console.WriteLine($" {GetName()} the {species} which  can talk = {CanTalk} squawks  and flies ");
    }
    public override void MakeSound()
    {
        Console.WriteLine($"{GetName()} the {species} of age {Age}  squawking");
    }

}