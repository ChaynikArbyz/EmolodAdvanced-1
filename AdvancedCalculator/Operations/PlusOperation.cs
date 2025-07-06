using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator.Operations
{
    internal class PlusOperation : BaseOperation
    {
        public override double Use()
        {
            Console.WriteLine("-Додавання-\n\nВведіть 1 число");
            double a;
            bool success = double.TryParse(Console.ReadLine(), out a);
            if (!success)
            {
                Console.WriteLine("Невірний формат числа. Будь ласка, спробуйте ще раз.");
                return 0;
            }
            Console.WriteLine("Введіть 2 число");
            double b;
            success = double.TryParse(Console.ReadLine(), out b);
            if (!success)
            {
                Console.WriteLine("Невірний формат числа. Будь ласка, спробуйте ще раз.");
                return 0;
            }
            Console.WriteLine($"Результат: {a} + {b} = {a + b}");
            return a + b;
        }
    }
}
