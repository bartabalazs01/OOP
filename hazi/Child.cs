using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersons
{
    class Child : Person
    {
        private string _school;
        public Child(string name, int age, string school) : base(name, age)
        {
            this._school = school;
        }

        public string School { get => _school; }

        public override string ToString()
        {
            return base.ToString() + $", School: {School}"; 
        }
    }
}
