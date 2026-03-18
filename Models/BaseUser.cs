using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs.Models
{
    public class BaseUser
    {
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int GroupNumber { get; set; }
        public string Birthday { get; set; }
        public string Adress { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Pasword { get; set; }
        public string Id { get; set; }
    }


}
