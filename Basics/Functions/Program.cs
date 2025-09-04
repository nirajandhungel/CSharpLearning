using System;
namespace Functions
{
    class Program
    {
        public static void Main(string[] args)
        {
            int checkNum = 5;
            IsOdd(3);
            Console.WriteLine(IsEven(checkNum));
        }

        // function with args and return value
        public static bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // function with args and no return value
        public static void IsOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"No, {num} is not an odd number");
            }
            else
            {
                Console.WriteLine($"Yes, {num} is an odd number");

            }
        }
    }
}