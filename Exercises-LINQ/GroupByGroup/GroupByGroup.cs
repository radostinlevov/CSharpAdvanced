using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public string FullName { get; set; }
    public int Group { get; set; }
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
            string fullName = studentInfo[0] + " " + studentInfo[1];
            string group = studentInfo[2];

            Student student = new Student();
            student.FullName = fullName;
            student.Group = int.Parse(group);

            students.Add(student);

            inputLine = Console.ReadLine();
        }

        var groupedStudents = students.GroupBy(st => st.Group).OrderBy(st => st.Key);

        foreach (var group in groupedStudents)
        {
            Console.WriteLine(group.Key + " - " + string.Join(", ", group.Select(n => n.FullName)));
        }
    }
}