using System;
using System.Collections.Generic;
using System.Linq;


namespace _1_PersonInfo
{
    public class Person
    {
        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
        public string  Name { get; set; }
        public string  LastName { get; set; }
        public string?  FullName { get; private set; }
       
        
        public void GenerateFullName()
        {
            FullName = Name + "  " + LastName;
        }
    }
}
