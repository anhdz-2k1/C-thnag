using System;

namespace Exescise2
{
    class Employee
    {
        private int empID;
        public Employee(int empID)
        {
            this.empID = empID;
        }
        public override string ToString()
        {
            return empID.ToString();
        }
    }
    class ObjectArray
    {
        public void Run()
        {
            int[] intArray;
            Employee[] emArray;
            intArray = new int[5];
            emArray = new Employee[3];
            for(int i = 0; i <emArray.Length; i++)
            {
                emArray[i] = new Employee(i + 5);
            }
            Console.WriteLine("The int array...");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i].ToString());
            }    
            Console.WriteLine("\nThe employee array...");
            for(int i = 0; i <emArray.Length; i++)
            {
                Console.WriteLine(emArray[i].ToString());
            }    
        }
        static void Main(string[] args)
        {
            ObjectArray arr = new ObjectArray();
            arr.Run();
            Console.ReadLine();
        }
    }

}
