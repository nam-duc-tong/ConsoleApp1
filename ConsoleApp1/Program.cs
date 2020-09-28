using System;

namespace ConsoleApp1
{
    public class BaseClass
    {
        private void PrivateMethod()
        {
            Console.WriteLine("Private Method");
        }
        public void PublicMethod()
        {
            Console.WriteLine("This Method Shared");
        }
    }
    public class DerivedClass1 : BaseClass
    {
        public void DerivedClass1()
        {
            Console.WriteLine("Derived Class 1");
        }

    }

    class Program : DerivedClass1
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.PublicMethod();
            obj.DerivedClass1();
            Console.WriteLine("Hello World!");
        }
    }
}
