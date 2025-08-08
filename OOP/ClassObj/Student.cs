using System;

namespace MyApp.StudentModel
{
    public class Student(string name, int age)
    {
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;

        public void Study()
        {
            Console.WriteLine($"{Name} is studying");
        }

        public void Query()
        {
            Console.WriteLine($"{Name} is asking questions!");
        }
    }
}
