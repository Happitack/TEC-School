using System;
using System.Collections.Generic;

namespace AfleveringFredag28
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("James", "Bond", 41, "JB007@MI6.uk.gov", 55412575);
            Person person2 = new Person("Robert", "Keen", 25, "RK20@email.com", 52698741);
            Person person3 = new Person("Hailey", "Steele", 31, "HS@email.com", 12665814);
            Person person4 = new Person("Hank", "Broody", 38, "HB811@mail.com", 44692578);
            Person person5 = new Person("Michael", "Reed", 41, "MR1@mail.com", 78236547);
            Person person6 = new Person("Sera", "Dorn", 51, "SD115@mail.gov", 55412575);
            Person person7 = new Person("Lara", "James", 31, "LJ2@MI6.uk.gov", 55412575);

            List<Person> ListeofPeople = new List<Person>() { person1, person2, person3, person4, person5, person6, person7 };

            foreach (var item in ListeofPeople)
            {
                Console.WriteLine(item.UdskivPerson());
            }

            Console.ReadLine();
        }
    }
}
