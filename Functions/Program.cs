using System;
namespace Functions
{
    class Program
    {
        public static void Main(string[] args)
        {
            int checkNum = 5;
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
    }
}