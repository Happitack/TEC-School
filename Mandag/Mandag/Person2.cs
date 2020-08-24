using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrienteretProg
{
    class Person2
    {
        // Fields
        private int age { get; set; }
        private string name { get; set; }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
