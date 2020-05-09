using System;

namespace assignment3
{
    class assignment3
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so ban chon : ");
            n = int.Parse(Console.ReadLine());
            if (n >  1 && n <  9)
            {
                if(n == 2)
                {
                    Console.WriteLine("Thu hai");
                } 
                else if( n == 3){
                    Console.WriteLine("Thu ba");
                }
                else if (n == 4)
                {
                    Console.WriteLine("Thu tu");
                }
                else if (n == 5)
                {
                    Console.WriteLine("Thu nam");
                }
                else if (n == 6)
                {
                    Console.WriteLine("Thu sau");
                }
                else if (n == 7)
                {
                    Console.WriteLine("Thu bay");
                }
                else if (n == 8)
                {
                    Console.WriteLine("Chu nhat");
                }
            }
            else {
                Console.WriteLine("Day khong phai mot ngay trong tuan");
            }
            
        }
    }
}
