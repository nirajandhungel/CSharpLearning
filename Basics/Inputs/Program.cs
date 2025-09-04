using System;
public class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number : ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"You entered : {num}");
    }
}