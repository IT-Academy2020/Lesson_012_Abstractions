using System;

// Абстрактний клас.

namespace Abstraction
{
    // Абстрактний клас.
    abstract class AbstractClass
    {
        public abstract void Method();
    }

    // Конкретний клас.
    class ConcreteClass : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("Implementation");
        }
    }

    class Program
    {
        static void Main()
        {
            AbstractClass instance = new ConcreteClass();

            instance.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
