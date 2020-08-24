using System;

namespace ObjectOrienteretProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            p1.setName("John Johnson");
            p1.setAge(55);

            Console.WriteLine($"p1 objekt navn: {p1.getName()}");
            Console.ReadKey();
        }
    }
}
