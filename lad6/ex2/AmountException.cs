using System;
using System.Transactions;

namespace ex2
{
    public class InvalidSalary : ApplicationException
    {
        public InvalidSalary() : base("Luong cua ban qua cao sao voi qui dinh") { }
    }
    public class InvalidBonus : ApplicationException
    {
        public InvalidBonus() : base("Bonus của ban qua cao so voi qui dinh") { }
    }
    class Name
    {
        public string name;
        public void getName()
        {
            Console.Write("Enter your name :");
            name = Console.ReadLine();
            Console.WriteLine("Your name is: " + name);
        }
    }
    class AmountException
    {
        public static void Main(string[] args)
        {
            Name name1 = new Name();
            name1.getName();
            double salary, bonus;
            try
            {
                Console.WriteLine("Enter Salary: ");
                salary = Convert.ToDouble(Console.ReadLine());
                if(salary > 60000.00)
                {
                    throw new InvalidSalary();
                }
            }
            catch (InvalidSalary objInvalidSalary)
            {
                Console.WriteLine(objInvalidSalary.Message);
            }
            catch (System.FormatException objFormatException)
            {
                Console.WriteLine(objFormatException.Message);
            }

            try
            {
                Console.WriteLine("Enter Bonus: ");
                bonus = Convert.ToDouble(Console.ReadLine());
                if (bonus > 10000.00)
                {
                    throw new InvalidBonus();
                }
            }
            catch (InvalidBonus objInvalidBonus)
            {
                Console.WriteLine(objInvalidBonus.Message);
            }
            catch (System.FormatException objFormatException)
            {
                Console.WriteLine(objFormatException.Message);
            }


        }
        
    }
}
