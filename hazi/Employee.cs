using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersons
{
    class Employee : Adult
    {
        private int _payment;
        public Employee(string name, int age, string workplace, int payment) : base(name, age, workplace)
        {
            this._payment = payment;
        }

        public int Payment { get => _payment; }

        public override string ToString()
        {
            return base.ToString() + $", Payment: {Payment}"; 
        }
    }
}
