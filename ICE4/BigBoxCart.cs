using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE4
{
    internal class BigBoxCart
    {
        public delegate string MyDelegate();//DELEGATE

        List<string> bigBox = new List<string>();
        List<double> deliveryPrice = new List<double>();
        List<string> warrantyExpiry = new List<string>();

        //CONSTRUCTOR
        public BigBoxCart(List<string> bigBox, List<double> deliveryPrice, List<string> warrantyExpiry)
        {
            this.bigBox = bigBox;
            this.deliveryPrice = deliveryPrice;
            this.warrantyExpiry = warrantyExpiry;
        }


        //INVOKE DELEGATE
        public void callDelegate()
        {
            MyDelegate big = new MyDelegate(getBigBoxCart);
            Console.WriteLine(big.Invoke());
        }


        //METHOD RETURNS CART INFO
        public string getBigBoxCart()
        {
            string display = "BIGBOX ORDER DETAILS: " + "\n";
            display += "-------------------------------" + "\n";

            for (int i = 0; i < bigBox.Count(); i++)
            {
                display += "BigBox Item " + (i + 1) + ": " + bigBox[i] + " \n";
                display += "Price of Delivery: " + deliveryPrice[i] + " \n";
                display += "Warranty Expiry Date: " + warrantyExpiry[i] + " \n";
            }
            display += "-------------------------------" + "\n";

            return display;
        }
    }
}