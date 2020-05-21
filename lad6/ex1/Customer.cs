using Customer;
using Order;
using System;
using System.Globalization;

namespace Customer
{
    class addName
    {
        public string Name;
        public void getName()
        {
            Console.Write("Enter your name :");
            Name = Console.ReadLine();
            Console.WriteLine("Your name is: " + Name);
        }
    }
}
namespace Order
{
    class Order1
    {

        public void Grocety()
        {
            int n;
            Console.WriteLine("Danh sach cac mat hang tap hoa: ");
            Console.WriteLine("1-Bim bim: ");
            Console.WriteLine("2-Snake ");
            Console.WriteLine("3-Cocacola ");
            Console.WriteLine("4-Pepsi ");

            do
            {

                do
                {
                    Console.Write("Nhap id mat pham ba muon mua: ");
                    n = Convert.ToInt32(Console.ReadLine());

                } while (n < 0 || n > 4);
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Ban da mua thang con bim bim");
                        break;
                    case 2:
                        Console.WriteLine("Ban da mua thanh cong Snake");
                        break;
                    case 3:
                        Console.WriteLine("Ban da mua thanh cong Cocacola");
                        break;
                    case 4:
                        Console.WriteLine("Ban da mua thanh cong Pepsi");
                        break;

                }
            } while (n != 0);
        }
        public void Bakery()
        {
            int n;
            Console.WriteLine("Danh sach cac mat hang tap hoa: ");
            Console.WriteLine("1-Banh my bate ");
            Console.WriteLine("2-Banh my trung ");
            Console.WriteLine("3-Banh my xuc xich ");
            Console.WriteLine("4-Banh my trung xuc xich ");

            do
            {
                do
                {
                    Console.Write("Nhap id mat pham ba muon mua: ");
                    n = Convert.ToInt32(Console.ReadLine());

                } while (n < 0 || n > 4);
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Ban da mua thang con bim bim");
                        break;
                    case 2:
                        Console.WriteLine("Ban da mua thanh cong Snake");
                        break;
                    case 3:
                        Console.WriteLine("Ban da mua thanh cong Cocacola");
                        break;
                    case 4:
                        Console.WriteLine("Ban da mua thanh cong Pepsi");
                        break;
                }
            } while (n != 0);
        }
    }
}
namespace Mainnnn{
    class Mainnn
    {
        public static void Main()
        {
            addName add1 = new addName();
            add1.getName();
            int n;
            Order1 o1 = new Order1();
            do
            {
                do
                {
                    Console.WriteLine("Danh sanh:");
                    Console.WriteLine("1-Tap hoa");
                    Console.WriteLine("2-Banh my");
                    Console.WriteLine("0-Ket thuc");
                    Console.Write("Nhap id mat pham ba muon mua: ");
                    n = Convert.ToInt32(Console.ReadLine());

                } while (n < 0 || n > 2);
                switch (n)
                {
                    case 1: o1.Grocety();
                        break;                        
                    case 2:
                        o1.Bakery();
                        break;                 
                }
            } while (n != 0);

        }
    }
}


