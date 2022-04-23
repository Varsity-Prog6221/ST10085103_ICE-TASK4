using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE4
{
    internal class Item
    {
        public double price;

        //CONSTRUCTOR
        public Item(double price)
        {
            this.price = price;
        }


        //CALCULATES ITEM VAT
        public double calculateVat()
        {
            double vat = price * 0.14;

            return vat;
        }
    }
}