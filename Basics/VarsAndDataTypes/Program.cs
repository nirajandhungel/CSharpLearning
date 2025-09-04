using System;
namespace VarsAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primitive Data Types
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
            Console.WriteLine("Name :{0}, age : {1}, is student : {2}, Height :{3}, Grade : {3}", name, age, isStudnet, height, grade);


            // Non-Primitive Data Types
            int[] numbers = { 1, 2, 3, 4, 5 }; // Array
            Console.WriteLine("First number in array : " + numbers[0]);


            var fruits = new List<string> { "Apple", "Banana", "Mango" }; // List
            fruits.Add("Orange");
            Console.WriteLine("Fruits in the list : ");

            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }


            var person = new Dictionary<string, string> // Dictionary
            {
                { "Name", "Nirajan" },
                { "City", "Kathmandu" },
                { "Country", "Nepal" }
            };
            Console.WriteLine("Person Details : ");
            foreach (var kvp in person)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }

          // Linked List
            var linkedList = new LinkedList<int>();
            linkedList.AddLast(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);
            Console.WriteLine("Elements in Linked List : ");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}