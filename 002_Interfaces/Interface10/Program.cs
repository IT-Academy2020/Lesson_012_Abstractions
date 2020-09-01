using System;

// Наслідування від класу і інтерфейсу у яких збігаються сигнатури членів.

namespace Interfaces
{
    interface IInterface
    {
        void Method();
    }

    class BaseClass
    {
        public void Method()
        {
            Console.WriteLine("BaseClass.Method()");
        }
    }

    class DerivedClass : BaseClass, IInterface
    {
        // Реалізація інтерфейсу не обов'язкова, тому що,
        // сигнатури методів в класі і інтерфейсі збігаються.
    }

    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            IInterface instance1 = instance as IInterface;
            instance1.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
