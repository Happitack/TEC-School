using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ObjectOrienteretProg
{
    class Person
    {
        // Fields
        private string name { get; set; }
        private string surname { get; set; }
        private int tele { get; set; }
        private string birthday { get; set; }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public int Tele
        {
            get { return tele; }
            set { tele = value; }
        }

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        // Methodes
        public void setName(string n) { name = n; }
        public string getName() { return name; }
        public void setSurname(string sn) { surname = sn; }
        public string getSurname() { return surname; }
        public void setTele(int t) { tele = t; }
        public int getTele() { return tele; }
        public void setBirthday(string b) { birthday = b; }
        public string getBirthday() { return birthday; }

        public static void UdskrivStatic(Person p)
        {
            Console.WriteLine($"Navn: {p.name} {p.surname} med telefon nummeret {p.tele} har fødselsdag {p.birthday}");
        }
    }
}
