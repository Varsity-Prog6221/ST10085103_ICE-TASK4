using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE4
{
    internal class GroceryCart
    {

        List<Item> itemPrice = new List<Item>();
        String[] itemsString = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        double vat;

        //CONSTRUCTOR 
        public GroceryCart(List<Item> itemPrice)
        {
            this.itemPrice = itemPrice;
        }


        //CALCULATE ITEN TOTAL
        public double getTotalPrice()
        {
            double total = 0;
            for (int i = 0; i < itemPrice.Count(); i++)
            {
                Item b = (Item)itemPrice[i];
                total = total + b.price;
            }

            vat = total * 0.14;

            return total;
        }


        //METHOD RETURNS CART INFO
        public override string ToString()
        {
            string display = "GROCERY ORDER DETAILS: " + "\n";
            display += "-------------------------------" + "\n";

            for (int i = 0; i < itemPrice.Count(); i++)
            {
                Item b = (Item)itemPrice[i];
                display += "Item " + itemsString[i] + " R " + b.price + "\n";
            }

            display += "-------------------------------" + "\n" +
            "TOTAL R " + getTotalPrice() + "\n" +
            "+ VAT R " + vat + "\n" +
            "-------------------------------" + "\n" +
            "Grand Total: R " + (getTotalPrice() + vat) +
            "\n-------------------------------" + "\n";

            return display;
        }
    }
}

