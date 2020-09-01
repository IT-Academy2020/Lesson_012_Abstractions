using System;

// Наслідування (реалізація) від інтерфейсів у яких збігаються імена членів.

// Об'єднання реалізації однойменних абстрактних членів.

namespace Interfaces
{
    interface IInterface1
    {
        void Method();
    }

    interface IInterface2
    {
        void Method();
    }

    class ConcreteClass : IInterface1, IInterface2
    {
        public void Method()
        {
            Console.WriteLine("Method - реалізація інтерфейсу IInterface (1-2)");
        }
    }

    class Program
    {
        static void Main()
        {
            ConcreteClass instance = new ConcreteClass();
            instance.Method();

            IInterface1 instance1 = instance as IInterface1;
            instance1.Method();

            IInterface2 instance2 = instance as IInterface2;
            instance2.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
