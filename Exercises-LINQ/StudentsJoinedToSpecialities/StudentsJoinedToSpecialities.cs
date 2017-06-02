using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public int facultyNumber;
    public string name;

    public Student(int facultyNumber, string name)
    {
        this.facultyNumber = facultyNumber;
        this.name = name;
    }
}
public class StudentSpeciality
{
    public string speciality;
    public int facultyNumber;

    public StudentSpeciality(string speciality, int facultyNumber)
    {
        this.speciality = speciality;
        this.facultyNumber = facultyNumber;
    }
}
public class StartUp
{
    static void Main()
    {
        List<StudentSpeciality> studentsSpeciality = new List<StudentSpeciality>();
        List<Student> students = new List<Student>();

        string inputSpeciality = Console.ReadLine();

        while (inputSpeciality != "Students:")
        {
            string[] specialityInfo = inputSpeciality.Split();
            string speciality = specialityInfo[0] + " " + specialityInfo[1];
            int facultyNumber = int.Parse(specialityInfo[2]);

            StudentSpeciality studentSpeciality = new StudentSpeciality(speciality, facultyNumber);
            studentsSpeciality.Add(studentSpeciality);

            inputSpeciality = Console.ReadLine();
        }

        string inputSudent = Console.ReadLine();

        while (inputSudent != "END")
        {
            string[] studentInfo = inputSudent.Split();
            int facultyNumber = int.Parse(studentInfo[0]);
            string name = studentInfo[1] + " " + studentInfo[2];

            Student student = new Student(facultyNumber, name);
            students.Add(student);

            inputSudent = Console.ReadLine();
        }

        var result = students.Join(studentsSpeciality,
                                   st => st.facultyNumber,
                                   ss => ss.facultyNumber,
                                   (st, ss) => new
                                   {
                                       NameWithNumber = st.name + " " + st.facultyNumber,
                                       Profession = ss.speciality,
                                   });

        foreach (var student in result.OrderBy(st => st.NameWithNumber))
        {
            Console.WriteLine(student.NameWithNumber + " " + student.Profession);
        }
    }
}
