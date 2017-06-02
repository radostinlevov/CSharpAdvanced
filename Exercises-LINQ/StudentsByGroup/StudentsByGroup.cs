using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Group { get; set; }
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
            int group = int.Parse(studentInfo[2]);

            Student student = new Student();
            student.FirstName = firstName;
            student.LastName = lastName;
            student.Group = group;

            students.Add(student);

            inputLine = Console.ReadLine();
        }

        students = students.Where(st => st.Group == 2).OrderBy(s => s.FirstName).ToList();

        foreach (var student in students)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }
    }
}
