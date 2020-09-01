using System;

namespace Interfaces
{
    class DerivedClass : Interface1, Interface2
    {
        // На 13-му рядку реалізовуємо метод з іменем Method з базового інтерфейсу Interface1
        // При реалізації методу використовуємо техніку явної вказівки імені інтерфейсу, якому належить даний метод,
        // перед іменем методу.

        // За замовчуванням однойменні методи є private,
        // але явно вказувати модифікатори доступу неможна.
        void Interface1.Method()
        {
            Console.WriteLine("Реалізація методу Method () з Interface1");
        }

        void Interface2.Method()
        {
            Console.WriteLine("Реалізація методу Method () з Interface2");
        }
    }
}
