using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Text;

namespace AfleveringFredag28
{
    class Person
    {
        private string kategori;
        public string Kategori
        {
            get { return kategori; }
            protected set { kategori = value; }
        }


        string Fname { get; set; }
        string Lname { get; set; }
        int Age { get; set; }
        string Email { get; set; }
        int Tele { get; set; }

        public Person(string fname, string lname, int age, string email, int tele)
        {
            kategori = "N/A";
            Fname = fname;
            Lname = lname;
            Age = age;
            Email = email;
            Tele = tele;
        }

        public Person()
        {
        }

        public virtual string UdskivPerson()
        {
            return $"Full Name: {Fname} {Lname}" + "\r\n" +
                $"Age: {Age }" + "\r\n" +
                $"Email: {Email}" + "\r\n" +
                $"Phone: {Tele}" + "\r\n" ;
        }
    }
    class Employee : Person
    {
        public int CreditCard { get; set; }
        public Employee()
        {

        }
        public Employee(string fname, string lname, int age, string email, int tele, int creditcard) : base (fname, lname, age, email, tele )
        {
            CreditCard = creditcard;
        }
        public override string UdskivPerson()
        {
            return base.UdskivPerson() + $"Creditcard: {CreditCard}" + "\r\n" ;
        }
    }

    class Customer : Person
    {
        public int WorkId { get; set; }
        public int PayAcc { get; set; }

        Customer()
        {

        }
        Customer(string fname, string lname, int age, string email, int tele, int workid, int payacc) : base (fname, lname, age, email, tele)
        {
            WorkId = workid;
            PayAcc = payacc;
        }

        public override string UdskivPerson()
        {
            return base.UdskivPerson() + $"Work ID: {WorkId}" + "\r\n" +
                                         $"Account Number: {PayAcc}" + "\r\n";
        }
    }
}
