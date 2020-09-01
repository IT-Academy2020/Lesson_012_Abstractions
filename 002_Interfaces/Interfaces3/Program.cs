using System;

// Явна вказівка імені інтерфейсу в імені методу.

namespace Interfaces
{
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();

            // instance. - // На екземплярі не бачимо методів інтерфейсів.

            // Приведемо екземпляр класу DerivedClass - instance, до базового багатофункціонального типу Interface1

            Interface1 instance1 = instance as Interface1;
            instance1.Method();

            Interface2 instance2 = instance as Interface2;
            instance2.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
