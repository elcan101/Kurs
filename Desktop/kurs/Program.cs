
using kurs.Models;

namespace kurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                username = "Elcan101",
                firstname = "Elcan",
                lastname = "Eliyev",
                groupnumber = 363625,
                birthday = "22.07.2006",
                email = "elcan@gmail.com",
                pasword = "salamdunya"
            };

            student.GetInfo();
        }
    }
}