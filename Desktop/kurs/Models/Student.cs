using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs.Models
{
    
 
    class Student
    {
         string username;
         string firstname;
         string lastname; 
         int groupnumber;
        int birthday; 
        string adress;
         int phonenumber;
         string email;
         string pasword;
         int score;

        public Student()
        {
           
        }

        public Student(string name, string firstname, string lastname, int groupnumber,
         int birthday,
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
         int birthday,
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
    }

}
