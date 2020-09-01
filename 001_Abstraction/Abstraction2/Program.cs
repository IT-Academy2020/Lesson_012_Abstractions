using System;

// Абстрактний клас може наслідуватись від конкретного класу.

namespace Abstraction
{
    // Конкретний клас A.
    class ConcreteClassA
    {
        public void Operation()
        {
            Console.WriteLine("ConcreteClassA.Operation");
        }
    }

    // Абстрактний клас.
    abstract class AbstractClass : ConcreteClassA
    {
        public abstract void Method();
    }

    // Конкретний клас B.
    class ConcreteClassB : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("ConcreteClassB.Method");
        }
    }

    class Program
    {
        static void Main()
        {
            AbstractClass instance = new ConcreteClassB();

            instance.Method();
            instance.Operation();

            // Delay.
            Console.ReadKey();
        }
    }
}
