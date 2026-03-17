using kurs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using kurs.Models;
public static class RegisterStudent
{
    static List<Student> students = new List<Student>();

    public static void Register(Student s)
    {
        students.Add(s);

        foreach (var item in students)
        {
            Console.WriteLine($"{item.firstname} {item.lastname}");
        }
        Console.WriteLine();
    }
}

