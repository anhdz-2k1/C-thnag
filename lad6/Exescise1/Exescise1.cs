using Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Customer
{
    class Cust_details

    {
        public string strNAme;
        public void getName()
        {
            Console.WriteLine("Enter your name :");
            strNAme = Console.ReadLine();
        }

    }
}
namespace Order
{
    class Grocety_items
    {
        public void Ord_grocery()
        {
            Cust_details objCust1 = new Cust_details();
            objCust1.getName();
            Console.WriteLine("Hello {0} ", objCust1.strNAme);
            Console.WriteLine("You  have ordered grocery items");
        }
    }
    class Bakery_items
    {
        public void Ord_bakery()
        {
            Cust_details objCust2 = new Cust_details();
            objCust2.getName();
            Console.WriteLine("Hello {0} ", objCust2.strNAme);
            Console.WriteLine("You  have ordered grocery items");
        }    
    }
    class OrderTest
    {
        public static void Main()
        {
            string choice;
            Console.WriteLine("What would you like to order? 1-Grocery Items, 2 - Bakery Items");
            choice = Console.ReadLine();
            if(choice == "1")
            {
                Grocety_items objGrocery = new Grocety_items();
                objGrocery.Ord_grocery();
            }
            else
            {
                if(choice == "2")
                {
                    Bakery_items objBakery = new Bakery_items();
                    objBakery.Ord_bakery();

                }
                else
                {
                    Console.WriteLine("Enter either 1 or 2 ");
                }
            }
            Console.ReadLine();
        }   
    }
}
