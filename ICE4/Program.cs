//EMMANUEL OGUNDIRAN
//STUDENT NUMBER: ST10085103
using System;
using System.Collections.Generic;


namespace ICE4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Item> itemPrice = new List<Item>();
            List<double> itemVat = new List<double>();

            List<string> bigBox = new List<string>();
            List<double> deliveryPrice = new List<double>();
            List<string> warrantyExpiry = new List<string>();

            String check = "";
            int i = 0;
            while (i < 26 && check != "x")
            {
                try
                {
                    //ENTER OR EXIT PROGRAM
                    Console.WriteLine("Press 'x' to exit, or Enter 'go' to continue.");
                    check = Console.ReadLine();
                    if (check == "x")
                    {
                        Console.WriteLine("Program ends..." + "\n");
                    }
                    //TO START PROGRAM
                    if (check == "go")
                    {
                        Console.WriteLine("Press 'g' to enter groceries, or 'b' for BigBox");
                        string checking = Console.ReadLine();
                        //ENTER GROCERY ITEMS
                        if (checking == "g")
                        {
                            Console.WriteLine("Enter price of  Grocery Item ");
                            double groceryPrice = Convert.ToDouble(Console.ReadLine());
                            Item obj = new Item(groceryPrice);
                            itemPrice.Add(obj);

                            itemVat.Add(obj.calculateVat());
                            ++i;
                        }
                        //ENTER BIGBOX ITEMS
                        if (checking == "b")
                        {
                            Console.WriteLine("Enter BigBox Item");
                            string bigBoxItem = Console.ReadLine();
                            bigBox.Add(bigBoxItem);

                            Console.WriteLine("Enter delivery price");
                            double delivPrice = Convert.ToDouble(Console.ReadLine());
                            deliveryPrice.Add(delivPrice);

                            Console.WriteLine("Enter expiry date of warranty");
                            string expiryDate = Console.ReadLine();
                            warrantyExpiry.Add(expiryDate);
                            ++i;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Error in input provided!");
                }
            }

            //INSTANCE OF GROCERY ITEMS
            GroceryCart secondObj = new GroceryCart(itemPrice);
            Console.WriteLine(secondObj.ToString());

            //INSTANCE OF BIGBOX ITEMS
            BigBoxCart newObj = new BigBoxCart(bigBox, deliveryPrice, warrantyExpiry);
            newObj.callDelegate();
        }
    }
}