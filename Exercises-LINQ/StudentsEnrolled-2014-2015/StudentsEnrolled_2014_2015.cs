using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string FacultyNumber { get; set; }
    public List<byte> Marks { get; set; }
}
class StartUp
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        string inputLine = Console.ReadLine();

        while (inputLine != "END")
        {
            string[] studentInfo = inputLine.Split();
            string facultyNumber = studentInfo[0];
            List<byte> marks = new List<byte>();

            for (int i = 1; i < studentInfo.Length; i++)
            {
                marks.Add(byte.Parse(studentInfo[i]));
            }

            Student student = new Student();
            student.FacultyNumber = facultyNumber;
            student.Marks = marks;

            students.Add(student);

            inputLine = Console.ReadLine();
        }

        students = students.Where(st => st.FacultyNumber.EndsWith("14") ||
                                  st.FacultyNumber.EndsWith("15")).ToList();

        foreach (var student in students)
        {
            Console.WriteLine(string.Join(" ", student.Marks));
        }
    }
}