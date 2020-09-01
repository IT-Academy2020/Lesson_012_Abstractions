using System;

namespace Abstraction
{
    abstract class AbstractClass
    {
        // Конструктор (Відпрацьовує першим).
        public AbstractClass()
        {
            Console.WriteLine("1 AbstractClass()");

            // Викликається реалізація методу з похідного класу - ConcreteClass.
            this.AbstractMethod();

            Console.WriteLine("2 AbstractClass()");
        }

        public abstract void AbstractMethod();
    }

    class ConcreteClass : AbstractClass
    {
        string s = "FIRST";

        // Конструктор (Відпрацьовує другим).
        public ConcreteClass()
        {
            Console.WriteLine("3 ConcreteClass()");
            s = "SECOND";
        }

        public override void AbstractMethod()
        {
            Console.WriteLine("Реалізація методу AbstractMethod () в ConcreteClass {0}", s);
        }
    }

    class Program
    {
        static void Main()
        {
            AbstractClass instance = new ConcreteClass();

            Console.WriteLine(new string('-', 55));

            instance.AbstractMethod();

            // Delay.
            Console.ReadKey();
        }
    }
}
