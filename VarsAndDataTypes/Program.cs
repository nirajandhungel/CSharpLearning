using System;
namespace VarsAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 19;
            string name = "Nirajan";
            bool isStudnet = true;
            double height = 5.7;
            char grade = 'A';
            // First : Displaying using +
            Console.WriteLine("Name : " + name + ", is student : " + isStudnet + ", Age: " + age + ", Height : " + height + ", Grade : " + grade);

            // Second : Prinitng using ${} , String Interpolation
            Console.WriteLine($" Name : {name}, Age : {age}, height: {height}, is student : {isStudnet}, Grade: {grade}");

            // Third : format string {0},{1}
            Console.WriteLine("Name :{0}, age : {1}, is student : {2}, Height :{3}, Grade : {3}",name,age,isStudnet,height,grade);
        }
    }
}