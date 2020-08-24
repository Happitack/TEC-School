using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrienteretProg
{
    class Person
    {
        // Fields
        private string name;
        private int age;

        // Methodes
        public void setName(string n) { name = n; }
        public string getName() { return name; }
        public void setAge(int a) { age = a; }
        public int getAge() { return age; }
    }
}
