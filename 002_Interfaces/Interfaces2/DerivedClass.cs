using System;

namespace Interfaces
{
    class DerivedClass : Interface1, Interface2
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