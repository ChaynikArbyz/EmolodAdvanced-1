using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator.Operations
{
    internal class KorinOperation : BaseOperation
    {
        public override double Use()
        {
            Console.WriteLine("-Корінь числа-\n\nВведіть число");
            double a;
            bool success = double.TryParse(Console.ReadLine(), out a);
            if (!success)
            {
                Console.WriteLine("Невірний формат числа. Будь ласка, спробуйте ще раз.");
                return 0;
            }

            if (a < 0)
            {
                Console.WriteLine("Не можна обчислити корінь з від'ємного числа.");
                return 0;
            }
            Console.WriteLine($"Корінь з {a} дорівнює {Math.Sqrt(a)}");
            return Math.Sqrt(a);
        }
    }
}
