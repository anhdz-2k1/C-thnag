using System;
using System.Collections.Generic;

namespace Practive
{
    abstract class Product
    {
        protected int id;
        protected string name;
        protected double price;
        protected string producer;
        public Product()
        {

        }
        public Product(int id, string name, double price, string producer)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.producer = producer;
        }

        public abstract double ComputeTax();

        public override string ToString()
        {
            return "id: " + this.id + ", name: " + this.name + ", price: " + this.price + ", producer:  " + this.producer;
        }
    }
    class Book : Product
    {
        public Book(int id, string name, double price, string producer) : base (id, name, price, producer)
        {
            
        }

        public override double ComputeTax()
        {
           return price*8/100;
        }

        public override string ToString()
        {
            return "ten sach:  " + name + "," + " gia: " + price + "," + " thue: " + (price * 8 / 100);
        }
    }
    class MobilePhone : Product
    {
        public MobilePhone(int id, string name, double price, string producer) : base(id, name, price, producer)
        {
            
        }
        public override double ComputeTax()
        {
            return price * 10 / 100;
        }
        public override string ToString()
        {
            return "ten sach: " + name + "," + "gia: " + price  + "," +  " thue: " + (price * 10 / 100);
        }
    }
    class Test
    {
        public static void Main(string[] args)
        {
            double TotalTax = 0;
          


            Product[] objProduct = new Product[6];
            
            objProduct[0] = new Book(1, "Toi tu duy la choi bong", 126000.00, "Pirlo");
            objProduct[1] = new Book(2, "Hoi ky Sir Alex", 156000.00, "Sir Alex");
            objProduct[2] = new Book(3, "Alex dan dat lanh dao chu chu khong quan li", 176000.00, "Sir Alex");
            objProduct[3] = new MobilePhone(4, "Iphone 11 Promax", 25000000.00, "Apple");
            objProduct[4] = new MobilePhone(5, "Samsung Galaxy s20+", 21000000.00, "Samsung");
            objProduct[5] = new MobilePhone(6, "Iphone 11", 20000000.00, "Apple");

            //ComputeTotalTax Book
            double taxBook = 0;
            for (int i = 0; i <= 2; i++)
            {
                taxBook += objProduct[i].ComputeTax();
                /*Console.WriteLine(listPr[i].ToString());*/
            }
            //ComputeTotalTax Mobilephone
            double taxMobilePhone = 0;
            for (int i = 3; i <= 5; i++)
            {
                taxMobilePhone += objProduct[i].ComputeTax();
                /*Console.WriteLine(listPr[i].ToString());*/
            }

            double computeTotaltax = 0;
            for (int i = 0; i < objProduct.Length; i++)
            {
                computeTotaltax += objProduct[i].ComputeTax();
                Console.WriteLine(objProduct[i].ToString());
            }

            Console.WriteLine("Compute Total tax of Book: " + taxBook);
            Console.WriteLine("Compute Total tax of MobilePhone: " + taxMobilePhone);
            Console.WriteLine("Compute Total tax : " + computeTotaltax);
        }
    }
}
