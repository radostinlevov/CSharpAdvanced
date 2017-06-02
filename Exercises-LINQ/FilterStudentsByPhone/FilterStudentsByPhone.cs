using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
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
            string phone = studentInfo[2];

            Student student = new Student();
            student.FirstName = firstName;
            student.LastName = lastName;
            student.Phone = phone;

            students.Add(student);

            inputLine = Console.ReadLine();
        }

        students = students.Where(st => st.Phone.StartsWith("02") ||
                                  st.Phone.StartsWith("+3592"))
                                  .ToList();

        foreach (var student in students)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }
    }
}