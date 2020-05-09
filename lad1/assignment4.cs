using System;

namespace assignment4
{
    class assignment4
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so ban chon : ");
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i < 10; i++)
            {
                int boiso = n * i;
                Console.WriteLine("Bo so cua so ban nhap la {0}", boiso);
            }
        }
    }
}
