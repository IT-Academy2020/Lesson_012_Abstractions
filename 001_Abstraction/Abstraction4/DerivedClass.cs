using System;

namespace Abstraction
{
    class ConcreteDerivedClass : AbstractBaseClass
    {
        // Перевизначений віртуальний метод VirtualMethod () базового абстрактного класу.
        // Якщо ми не перевизначили віртуальний метод, то буде використаний метод з базового класу.

        public override void VirtualMethod()
        {
            Console.WriteLine("DerivedClass.VirtualMethod();");
        }

        // Реалізуємо абстрактний метод AbstractMethod () базового абстрактного класу.

        public override void AbstractMethod()
        {
            Console.WriteLine("DerivedClass.AbstractMethod();");
        }
    }
}
