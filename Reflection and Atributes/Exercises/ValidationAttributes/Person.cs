using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    public class Person
    {
        public Person(string name, int age)
        {
            this.FullName = name;
            this.Age = age;

        }


        [MyRange(12,90)]
        public int Age { get; set; }

        [MyRequired]
        public string FullName { get; set; }
    }
}
