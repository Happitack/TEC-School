using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrienteretProg
{
    class Person2
    {
        // Fields
        private string Fnavn { get; set; }
        private string Enavn { get; set; }
        private double Salery { get; set; }

        public static void UdskrivStatic(Person2 p)
        {
            Console.WriteLine($"Navn: {p.Fnavn} {p.Enavn} får {p.Salery: C2} i løn om måneden");
        }
    }


}
