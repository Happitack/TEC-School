using System;
using System.Collections.Generic;

namespace ObjectOrienteretProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person2 p2 = new Person2();

            p1.setName("John Johnson");
            p1.setAge(55);

            Person2 p3 = new Person2() { Age = 42, Name="James" };

            List<int> listInt = new List<int>();
            listInt.Add(4);

            List<Person2> listPerson2 = new
                List<Person2>();
            listPerson2.Add(p2);
            listPerson2.Add(p3);

            Console.WriteLine($"p1 objekt navn: {p1.getName()}");
            Console.ReadKey();
        }
    }
}
