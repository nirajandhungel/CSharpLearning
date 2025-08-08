using System;
using MyApp.StudentModel;

public class Program
{
    public static void Main(string[] args)
    {
        var stu1 = new Student("Nirajan", 19);
        stu1.Study();
        stu1.Query();
    }
}
