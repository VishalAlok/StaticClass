using System;

namespace StaticClass
{
    static class Student
    {
        static int RollNumber;
        static string StudentName = string.Empty;
        public static void Details()
        {
            Console.WriteLine("Student RollNumber is " + RollNumber + " and Name is " + StudentName);
        }

        static Student()
        {
            RollNumber = 100;
            StudentName = "Vishal";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student.Details();
        }
    }
}
