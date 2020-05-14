using System;

namespace Exescise1
{
    class Program
    {
        static void Main(string[] args)
        {
             long number = 0,n;
             int i = 0;
            string symbol = null, fullname = null;
            double weight = 0.000;
            Console.Write("Atomic Information ");
            Console.WriteLine("==================");
            Console.Write("Enter the prime number you want to add:");
            n = Convert.ToInt32(Console.ReadLine());
            for(i = 0; i < n; i++)
            {
                Console.Write("Enter atomic number: ");
                number = Convert.ToInt16(Console.ReadLine());
                
                if(number == 0)
                {
                    Console.WriteLine("No Sym Name Weigh");
                }  else if(number > 0)
                {
                    Console.Write("Enter symbol : ");
                    symbol = Console.ReadLine();
                    Console.Write("Enter full name : ");
                    fullname = Console.ReadLine();
                    Console.Write("Enter atomic weight: ");
                    weight = Convert.ToSingle(Console.ReadLine());
                    Console.Write(number);
                    Console.Write(" {0:n}", symbol);
                    Console.Write(" {0:n}", fullname);
                    Console.WriteLine(" {0:n}", weight);

                }  
            }           
        }
    }
}
