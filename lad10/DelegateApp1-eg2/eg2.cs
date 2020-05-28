using System;
delegate int NumberChanger(int n);

namespace DelegateApp1_eg2
{
   class TestDelegate
    {
        static int num = 10;
        public static int addNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(addNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            nc = nc1;
            nc += nc2;

            nc(5);
            Console.WriteLine("Value of Num: {0} ", getNum());
            Console.ReadKey();
            
        }
    }
}
