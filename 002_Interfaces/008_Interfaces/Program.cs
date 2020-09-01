using System;

// Наслідування абстрактних класів від інтерфейсів.

namespace Interfaces
{
    interface Interface
    {
        void Method();
    }

    abstract class AbstractClass : Interface
    {
        // Заміщення (приховування) абстрактного методу з інтерфейсу, в абстрактному класі є обов'язковим.
        public abstract void Method();      
    }

    class ConcreteClass : AbstractClass
    {
        // Реалізація абстрактного методу з абстрактного класу, в конкретному класі є обов'язковим.
        public override void Method()
        {
            Console.WriteLine("Метод - реалізація інтерфейсу в абстрактному класі.");
        }
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
