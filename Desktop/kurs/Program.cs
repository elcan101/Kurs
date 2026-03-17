
using kurs.Models;

namespace kurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Elcan = new Student()
            {
                username = "Elcan101",
                firstname = "Elcan",
                lastname = "Eliyev",
                groupnumber = 363625,
                birthday = "22.07.2006",
                email = "elcan@gmail.com",
                pasword = "salamdunya"
            };

            Student Ali = new();
            Ali.username = "Elcan101";
            Ali.firstname = "Elcan";
               Ali.lastname = "Eliyev";
            Ali.groupnumber = 363625;
               Ali.birthday = "22.07.2006";
               Ali.email = "elcan@gmail.com";
               Ali.pasword = "salamdunya";

            Student Aqsin = new();
            Aqsin.username = "aqsin";
            Aqsin.firstname = "aqsin";
            Aqsin .lastname = "Eliyev";
            Aqsin.groupnumber = 363625;
            Aqsin.birthday = "22.07.2006";
            Aqsin.email = "aqsin@gmail.com";
            Aqsin.pasword = "salamdunya";

            Student Niyaz = new();
            Niyaz.username = "niyaz";
            Niyaz.firstname = "niyaz";
            Niyaz.lastname = "Eliyev";
            Niyaz.groupnumber = 363625;
            Niyaz.birthday = "22.07.2006";
            Niyaz.email = "niyaz@gmail.com";
           Niyaz.pasword = "salamdunya";

            Student Tural= new();
            Tural.username = "tural";
            Tural.firstname = "tural";
            Tural.lastname = "Eliyev";
            Tural.groupnumber = 363625;
            Tural.birthday = "22.07.2006";
            Tural.email = "niyaz@gmail.com";
            Tural.pasword = "salamdunya";
            

            Student Nihat = new();
            Nihat.username = "nihat";
            Nihat.firstname = "Nihat";
            Nihat.lastname = "Memmedov";
            Nihat.groupnumber = 363626;
            Nihat.birthday = "15.03.2005";
            Nihat.email = "nihat@gmail.com";
            Nihat.pasword = "parol123";

            Student Aysel = new();
            Aysel.username = "aysel";
            Aysel.firstname = "Aysel";
            Aysel.lastname = "Huseynova";
            Aysel.groupnumber = 363627;
            Aysel.birthday = "10.11.2004";
            Aysel.email = "aysel@gmail.com";
            Aysel.pasword = "ayselpass";

            Student Kamran = new();
            Kamran.username = "kamran";
            Kamran.firstname = "Kamran";
            Kamran.lastname = "Quliyev";
            Kamran.groupnumber = 363628;
            Kamran.birthday = "05.01.2006";
            Kamran.email = "kamran@gmail.com";
            Kamran.pasword = "kamran123";

            Student Leyla = new();
            Leyla.username = "leyla";
            Leyla.firstname = "Leyla";
            Leyla.lastname = "Aliyeva";
            Leyla.groupnumber = 363629;
            Leyla.birthday = "30.09.2005";
            Leyla.email = "leyla@gmail.com";
            Leyla.pasword = "leyla456";

            RegisterStudent.Register(Leyla);
            RegisterStudent.Register(Kamran);

            // student.GetInfo();
        }
    }
}