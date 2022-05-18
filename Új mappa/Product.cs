using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproducts
{
    class Product
    {
        private string _name;
        private int _netPrice;
        private int _vat;
        private int _grossPrice;

        public int GrossPrice { get => _grossPrice; }
        public int NetPrice { get => _netPrice; set => _netPrice = value; }
        public int Vat { get => _vat; set => _vat = value; }

        public Product(string name, int netPrice, int vat)
        {
            _name = name;
            _netPrice = netPrice;
            _vat = vat;
            double v = (double)vat;
            double nP = (double)netPrice;
            _grossPrice = (int)((1 + v/100)*nP);
        }



        public override string ToString()
        {
            return $"Name: {_name}, Gross price: {_grossPrice}"; 
        }

        public void IncreasePrice(int percent)
        {
            _netPrice = _netPrice * percent;
        }

        public int CompareProducts(Product product)
        {
            if (this._grossPrice < product._grossPrice)
            {
                return -1;
            }
            else if (this._grossPrice > product._grossPrice)
            {
                return 1;
            }
            else return 0;
        }

    }
}
