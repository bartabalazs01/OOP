using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersons
{
    class Person
    {
        private string _name;
        private int _age;

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string Name { get => _name; }
        public int Age { get => _age; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}"; 
        }

        public bool YoungerThan(Person person)
        {
            return Age > person.Age;
        }
    }
}
