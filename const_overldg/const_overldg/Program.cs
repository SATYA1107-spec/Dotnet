using System;

namespace ConstructorReuseDemo
{
    // Base class
    class Student
    {
        public string Name;
        public int Age;

        // Constructor 1
        public Student(string name)
        {
            Console.WriteLine("Student(string) constructor called");
            Name = name;
            Age = 0;
        }

        // Constructor 2
        public Student(string name, int age)
        {
            Console.WriteLine($"Student(string, int){name} {age}constructor called");
            Name = name;
            Age = age;
        }

        public void ShowStudent()
        {
            Console.WriteLine($"Student → Name: {Name}, Age: {Age}");
        }
    }

    // Derived class
    class GraduateStudent : Student
    {
        public string Thesis;

        // Constructor 1: reuse Student(string)
        public GraduateStudent(string name) : base(name)
        {
            Console.WriteLine("GraduateStudent(string) constructor called");
            Thesis = "Not Assigned";
        }

        // Constructor 2: reuse Student(string, int)
        public GraduateStudent(string name, int age, string thesis) : base(name, age)
        {
            Console.WriteLine("GraduateStudent(string, int, string) constructor called");
            Thesis = thesis;
        }

        public void ShowGraduateStudent()
        {
            ShowStudent();
            Console.WriteLine($"Thesis: {Thesis}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n--- Graduate Student 1 ---");
            GraduateStudent gs1 = new GraduateStudent("Ravi");
            gs1.ShowGraduateStudent();

            Console.WriteLine("\n--- Graduate Student 2 ---");
            GraduateStudent gs2 = new GraduateStudent("Lakshmi", 24, "AI in Education");
            gs2.ShowGraduateStudent();
        }
    }
}
