using System;
namespace Conditional
{ 

public class Program
{
    public static void Main(string[] args)
    {
        int number = 10;

        // If-Else Statement
        if (number > 0)
        {
            Console.WriteLine($"{number} is a positive number.");
        }
        else if (number < 0)
        {
            Console.WriteLine($"{number} is a negative number.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }

        // Switch Statement
        int day = 3;
        string dayName = day switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => "Invalid day"
        };
        Console.WriteLine($"Day {day} is {dayName}.");

            // Another way switch statement
        
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");       
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7: 
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
        }

        // Ternary Operator
        int age = 19;
        string result = (age > 18) ? "Adult" : "Minor";
        Console.WriteLine(result);
    }
}

}
