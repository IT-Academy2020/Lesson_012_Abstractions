using System;

// Спадкування абстрактних класів від інтерфейсів.

namespace Interfaces
{
    interface Interface
    {
        void Method();
    }

    abstract class AbstractClass : Interface
    {
        // Реалізація абстрактного методу з інтерфейсу, в абстрактному класі обов'язкове.
        public void Method()
        {
            Console.WriteLine("Метод - реалізація інтерфейсу в абстрактному класі.");
        }
    }

    class ConcreteClass : AbstractClass
    {
    }

    class Program
    {
        static void Main()
        {
            ConcreteClass instance = new ConcreteClass();
            instance.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
