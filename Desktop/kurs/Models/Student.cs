using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs.Models
{
    
 
    class Student
    {
        public  string username;
        public string firstname;
        public string lastname;
        public int groupnumber;
        public string birthday;
        public string adress;
        public  int phonenumber;
        public  string email;
        public string pasword;
        public int score;

        public Student()
        {
           
        }

        public Student(string name, string firstname, string lastname, int groupnumber,
         string birthday,
         string email,string pasword)
        {
            this.username = name;
            this.firstname = firstname;
            this.lastname = lastname;
            this.groupnumber = groupnumber;
            this.birthday = birthday;
            this.email = email;
            this.pasword = pasword;

        }

        public Student(string name, string firstname, string lastname, 
         string pasword,
         string email)
        {
            this.username = name;
            this.firstname = firstname;
                this.lastname = lastname;
            this.pasword = pasword;
                this.email = email;
            }


        public Student(string name, string firstname, string lastname, int groupnumber,
         string birthday,
         string adess,
         int phonenumber,
         string email,
        string pasword,
         int score)
        {
            this.username = name;
            this.firstname = firstname;
            this.lastname = lastname;
            this.groupnumber = groupnumber;
            this.birthday = birthday;
            this.adress = adess;
        this.phonenumber = phonenumber;
        this.email = email;
        this.pasword = pasword;
        this.score = score;
        }   

        public void GetInfo()
        {
            Console.WriteLine($"username:{username} firstname: {firstname} lastname: {lastname} groupnumber:{groupnumber} birthday: {birthday}");

        }
            
    }

}
