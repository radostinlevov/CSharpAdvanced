﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
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
            string email = studentInfo[2];

            Student student = new Student();
            student.FirstName = firstName;
            student.LastName = lastName;
            student.Email = email;

            students.Add(student);

            inputLine = Console.ReadLine();
        }

        students = students.Where(st => st.Email.EndsWith("@gmail.com")).ToList();

        foreach (var student in students)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }
    }
}