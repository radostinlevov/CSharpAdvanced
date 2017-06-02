using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
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
            string firstName = studentInfo[0];
            string lastName = studentInfo[1];
            List<byte> marks = new List<byte>();

            for (int i = 2; i < studentInfo.Length; i++)
            {
                marks.Add(byte.Parse(studentInfo[i]));
            }

            Student student = new Student();
            student.FirstName = firstName;
            student.LastName = lastName;
            student.Marks = marks;

            students.Add(student);

            inputLine = Console.ReadLine();
        }

        students = students.Where(st => st.Marks.Contains(6)).ToList();

        foreach (var student in students)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }
    }
}