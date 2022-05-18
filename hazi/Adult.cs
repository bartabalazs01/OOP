using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersons
{
    class Adult : Person
    {
        private string _workplace;
        public Adult(string name, int age, string workplace) : base(name, age)
        {
            this._workplace = workplace;
        }

        public string Workplace { get => _workplace; }

        public override string ToString()
        {
            return base.ToString() + $", Workplace: {Workplace}";
        }
    }
}
