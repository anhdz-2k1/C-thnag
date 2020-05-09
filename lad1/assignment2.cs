using System;


namespace assignment2
{
    class assignment2
    {
        static void Main(string[] args)
        {
            int num1,num2,num3;
            
            Console.Write("\nNHAP SO THU NHAT : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nNHAP SO THU HAI : ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("\nNHAP SO THU BA : ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("So {0} la so lon nhat trong ba so ", num1);
                }
                else
                {
                    Console.Write("So {0} la so lon nhat trong ba so ", num3);
                }
            }
            else if (num2 > num3)
                Console.Write("So {0} la so lon nhat trong ba so ", num2);
            else
                Console.Write("So {0} la so lon nhat trong ba so " , num3);

            Console.ReadKey();
        }
    }
}
