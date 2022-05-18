using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproducts
{
    class Bread : Product
    {
        private double _quantity;

        public double Quantity { get => _quantity; }

        public Bread(string name, int netPrice, int vat, double quantity) : base(name, netPrice, vat)
        {
            _quantity = quantity;
        }

        public override string ToString()
        {
            return base.ToString() + $", Unit price: {GrossPrice/_quantity}, Quantity: {_quantity}"; 
        }

        public bool CompareBreads(Bread bread)
        {
            return (GrossPrice / _quantity) > (bread.GrossPrice / bread._quantity);
        }
    }
}
