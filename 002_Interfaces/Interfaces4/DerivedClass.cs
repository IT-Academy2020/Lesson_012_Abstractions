using System;

// В C# множинне наслідування (реалізація) є доступне лише використовуючи інтерфейси.
// Множинне наслідування (реалізації) (тобто від двох і більше класів або структур) неприпустимо.
// Припустимо множинне наслідування від одного класу і багатьох інтерфейсів.

namespace Interfaces
{
    class DerivedClass : BaseClass, Interface1, Interface2
    {
        public void Method1()
        {
            Console.WriteLine("Реалізація методу Method1 () з Interface1");
        }

        public void Method2()
        {
            Console.WriteLine("Реалізація методу Method2 () з Interface2");
        }
    }
}