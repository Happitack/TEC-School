using System;
using System.Collections.Generic;
using System.Text;

namespace AfleveringFredag28
{
    class Person
    {
        string Fname{ get; set; }
        string Lname { get; set; }
        int Age { get; set; }
        string Email { get; set; }
        string Tele { get; set; }

        public Person(string fname, string lname, int age, string email, string tele)
        {
            Fname = fname; Lname = lname; Age = age; Email = email; Tele = tele;
        }

        public Person()
        {

        }
    }
    class Employee : Person
    {

    }

    class Customer : Person
    {

    }
}
