using System;

// Абстрактний клас може наслідуватись від абстрактного класу.
// Реалізація абстрактного методу з базового абстрактного класу, у похідному абстрактному класі - не обов'язкова.

namespace Abstraction
{
    // Абстрактний клас A.
    abstract class AbstractClassA
    {
        public abstract void OperationA();
    }

    // Абстрактний клас B.
    abstract class AbstractClassB : AbstractClassA
    {
        public abstract void OperationB();
    }

    // Конкретний клас.
    class ConcreteClass : AbstractClassB
    {
        public override void OperationA()
        {
            Console.WriteLine("ConcreteClass.OperationA");
        }

        public override void OperationB()
        {
            Console.WriteLine("ConcreteClass.OperationB");
        }
    }

    class Program
    {
        static void Main()
        {
            AbstractClassA instance = new ConcreteClass();

            instance.OperationA();

            //instance.OperationB();  // Питання: чому недоступний даний метод?

            // Delay.
            Console.ReadKey();
        }
    }
}
