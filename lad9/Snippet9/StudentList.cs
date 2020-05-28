using System;
using System.Collections;
using System.Collections.Generic;

namespace Snippet9
{
    class GeneraList<T>
    {
        protected T ItemOne;
        public GeneraList(T valOne)
        {
            ItemOne = valOne;
        }
        public virtual T GetValue()
        {
            return ItemOne;
        }
    }
    class Student<T> : GeneraList<T>
    {
        public T Value;
        public Student (T valOne, T valTwo) : base(valOne)
        {
            Value = valTwo;
        }
        public override T GetValue()
        {
            Console.Write(base.GetValue() + "\t\t");
            return Value;
        }
    }
    class StudentList
    {
        public static void Main()
        {
            Student<string> objStudent = new Student<string>("Patrick", "Male");
            Console.WriteLine("Name\t\tSex"); 
            Console.WriteLine(objStudent.GetValue());
        }
    }
}
