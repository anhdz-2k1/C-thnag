using System;

namespace Snippet7
{
    class Calculate
    {
        public static void Addition(int vall, int vall2)
        {
            Console.WriteLine(vall + vall2);
        }
        public void Maltiply(int vall, int vall2)
        {
            Console.WriteLine(vall * vall2);
        }
    }
    class StaticMethods
    {
        static void Main(string[] args)
        {
            Calculate.Addition(10, 50);
            Calculate objCal = new Calculate();
            objCal.Maltiply(10, 20);
        }
    }
}
