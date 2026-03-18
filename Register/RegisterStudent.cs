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
            Console.WriteLine($"{item.Firstname} {item.Lastname}");
        }
        Console.WriteLine();
    }

    public static void Login(string username, string password)
    {
        var user = students.FirstOrDefault(s =>
            s.Username == username && s.Pasword == password);

        if (user != null)
        {
            Console.WriteLine($" {user.Firstname} {user.Lastname}");
        }
        else
        {
            Console.WriteLine("Username və ya şifrə yanlışdır!");
        }
    }
}

