using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace AddressBook
{
    public class Student
    {
        public Student() { }
        public Student(string no, string name, string sex, int? birthyear, string contact, string address)
        {
            No = no;
            Name = name;
            Sex = sex;
            Birthyear = birthyear;
            Contact = contact;
            Address = address;
        }

        public string No { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int? Birthyear { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }

    }
}
