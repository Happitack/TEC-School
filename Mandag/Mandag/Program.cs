using System;
using System.Collections.Generic;

namespace ObjectOrienteretProg
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person() { Name = "Abraham", Surname = "Lincoln"};
            Person p2 = new Person() { Name = "Gilbert", Surname = "Skysovs"};
            Person p3 = new Person() { Name = "Flomme" };
            Person p4 = new Person() { Name = "Blomme"};
            Person p5 = new Person() { Name = "Alexander"};

            // Abraham
            p1.setTele(28123126);
            p1.setBirthday("12/0/1809");

            // Gilbert
            p2.setTele(67812931);
            p1.setBirthday("16/12/1986");

            // Flomme
            p3.setSurname("Rommeling");
            p3.setTele(69856151);
            p3.setBirthday("07/10/1989");

            // Blomme
            p4.setSurname("Solkvang");
            p4.setTele(54558471);
            p4.setBirthday("01/06/1991");

            // Alexander
            p5.setSurname("the Great");
            p5.setTele(00021454);
            p5.setBirthday("01/06/356");


            List<Person> listPersons = new List<Person>();

            listPersons.Add(p1);
            listPersons.Add(p2);
            listPersons.Add(p3);
            listPersons.Add(p4);
            listPersons.Add(p5);

            //foreach (var item in listPersons)
            //{
            //    Console.WriteLine("Name: " + item.Name + " " + item.Surname);
            //    Console.WriteLine("Phone: " + item.Tele);
            //    Console.WriteLine("Birthday: " + item.Birthday);
            //    Console.WriteLine();
                
            //}

            Person.UdskrivStatic(p1);

            Console.ReadKey();
        }
    }
}
