
using kurs.Models;

namespace kurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Elcan = new Student()
            {
                Username = "Elcan101",
                Firstname = "Elcan",
                Lastname = "Eliyev",
                groupnumber = 363625,
                Birthday = "22.07.2006",
                Email = "elcan@gmail.com",
                Pasword = "salamdunya",
                Id = "3452"
            };

            Student Ali = new();
            Ali.Username = "Elcan101";
            Ali.Firstname = "Elcan";
            Ali.Lastname = "Eliyev";
            Ali.GroupNumber = 363625;
            Ali.Birthday = "22.07.2006";
            Ali.Email = "elcan@gmail.com";
            Ali.Pasword = "salamdunya";
            Ali.Id = "3565";

            Student Aqsin = new();
            Aqsin.Username = "aqsin";
            Aqsin.Firstname = "aqsin";
            Aqsin.Lastname = "aqsin";
            Aqsin.groupnumber = 363625;
            Aqsin.Birthday = "22.07.2006";
            Aqsin.Email = "aqsin@gmail.com";
            Aqsin.Pasword = "salamdunya";
            Aqsin.Id = "2565";

            Student Niyaz = new();
            Niyaz.Username = "niyaz";
            Niyaz.Firstname = "niyaz";
            Niyaz.Lastname = "Eliyev";
            Niyaz.groupnumber = 363625;
            Niyaz.Birthday = "22.07.2006";
            Niyaz.Email = "niyaz@gmail.com";
            Niyaz.Pasword = "salamdunya";
            Niyaz.Id = "3585";

            Student Tural = new();
            Tural.Username = "tural";
            Tural.Firstname = "tural";
            Tural.Lastname = "Eliyev";
            Tural.groupnumber = 363625;
            Tural.Birthday = "22.07.2006";
            Tural.Email = "niyaz@gmail.com";
            Tural.Pasword = "salamdunya";
            Tural.Id = "35610";

            Student Nihat = new();
            Nihat.Username = "nihat";
            Nihat.Firstname = "Nihat";
            Nihat.Lastname = "Memmedov";
            Nihat.groupnumber = 363626;
            Nihat.Birthday = "15.03.2005";
            Nihat.Email = "nihat@gmail.com";
            Nihat.Pasword = "parol123";
            Nihat.Id = "3569";


            Student Aysel = new();
            Aysel.Username = "aysel";
            Aysel.Firstname = "Aysel";
            Aysel.Lastname = "Huseynova";
            Aysel.groupnumber = 363627;
            Aysel.Birthday = "10.11.2004";
            Aysel.Email = "aysel@gmail.com";
            Aysel.Pasword = "ayselpass";
            Aysel.Id = "3568";

            Student Kamran = new();
            Kamran.Username = "kamran";
            Kamran.Firstname = "Kamran";
            Kamran.Lastname = "Quliyev";
            Kamran.groupnumber = 363628;
            Kamran.Birthday = "05.01.2006";
            Kamran.Email = "kamran@gmail.com";
            Kamran.Pasword = "kamran123";
            Kamran.Id = "3567";

            Student Leyla = new();
            Leyla.Username = "leyla";
            Leyla.Firstname = "Leyla";
            Leyla.Lastname = "Aliyeva";
            Leyla.groupnumber = 363629;
            Leyla.Birthday = "30.09.2005";
            Leyla.Email = "leyla@gmail.com";
            Leyla.Pasword = "leyla456";
            Leyla.Id = "3566";


            RegisterStudent.Register(Leyla);
            RegisterStudent.Register(Kamran);

            Console.Write("Username daxil et: ");
            string username = Console.ReadLine();

            Console.Write("Password daxil et: ");
            string password = Console.ReadLine();

            RegisterStudent.Login(username, password);
            // student.GetInfo();
        } 
    }
}