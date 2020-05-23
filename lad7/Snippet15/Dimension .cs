using System;

namespace Snippet15
{
    class Dimension
    {
        double length;
        double breadth;
        public double Area(double _length, double _breadth) 
        { 
            this.length = _length; 
            this.breadth = _breadth; 
            return length * breadth; 
        }
        static void Main(string[] args)
        {
            Dimension objDimension = new Dimension();
            Console.WriteLine("Area of rectangle = " +objDimension.Area(10.5, 12.5));
        }
    }
}
