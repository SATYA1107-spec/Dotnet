using EntityDemo.data;
using EntityDemo.Dbcontext;
using Microsoft.EntityFrameworkCore;
using System;

SchoolContext sc1 = new SchoolContext();
Student student1 = new Student()
{
    Name = "satya",
    Age = 25,
    Course = "donet"

};
sc1.Add(student1);
sc1.SaveChanges();

{
    var students = sc1.Students.ToList();

    foreach (var s in students)
    {
        Console.WriteLine(s.StudentId);
        Console.WriteLine(s.Name);
        Console.WriteLine(s.Age);
        Console.WriteLine(s.Course);
    }
}