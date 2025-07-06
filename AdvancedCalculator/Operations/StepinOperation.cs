using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator.Operations
{
    internal class StepinOperation : BaseOperation
    {
        public override double Use()
        {
            Console.WriteLine("-Степінь числа-\n\nВведіть число");
            double a;
            bool success = double.TryParse(Console.ReadLine(), out a);
            if (!success)
            {
                Console.WriteLine("Невірний формат числа. Будь ласка, спробуйте ще раз.");
                return 0;
            }
            Console.WriteLine("Введіть степінь");
            double b;
            success = double.TryParse(Console.ReadLine(), out b);
            if (!success)
            {
                Console.WriteLine("Невірний формат степеню. Будь ласка, спробуйте ще раз.");
                return 0;
            }
            Console.WriteLine($"Результат: {a} ^ {b} = {Math.Pow(a, b)}");
            return Math.Pow(a, b);
        }
    }
}
