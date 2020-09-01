using System;

namespace Abstraction
{
    abstract class AbstractBaseClass
    {
        // 1.
        // SimpleMethod передається похідному класу під час наслідування базового класу.
        public void SimpleMethod()
        {
            Console.WriteLine("AbstractBaseClass.SimpleMethod");
        }

        // 2.
        // Віртуальний метод передається похідному класу під час наслідування базового класу.
        virtual public void VirtualMethod()
        {
            Console.WriteLine("AbstractBaseClass.VirtualMethod");
        }

        // 3.
        // Абстрактний метод - реалізується в похідному класі.
        abstract public void AbstractMethod();
    }
}
