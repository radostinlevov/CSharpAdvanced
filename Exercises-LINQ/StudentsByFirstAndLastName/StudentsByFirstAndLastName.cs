using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
public class StartUp
{
    public static void Main()
    {
        List<Student> students = new List<Student>();

        string inputLine = Console.ReadLine();

        while (inputLine != "END")
        {
            string[] studentInfo = inputLine.Split();
            string firstName = studentInfo[0];
            string lastName = studentInfo[1];

            Student student = new Student();
            student.FirstName = firstName;
            student.LastName = lastName;

            students.Add(student);

            inputLine = Console.ReadLine();
        }

        students = students.Where(st => st.FirstName.CompareTo(st.LastName) < 0).ToList();

        foreach (var student in students)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }
    }
}
