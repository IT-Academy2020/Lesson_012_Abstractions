using System;

// Інтерфейси.

namespace Interfaces
{
    interface IInterface
    {
        void Method();
    }

    class MyClass : IInterface
    {
        public void Method()
        {
            Console.WriteLine("Метод - реалізація інтерфейсу.");
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass my = new MyClass();

            my.Method();

            //Delay.
            Console.ReadKey();
        }
    }
}
