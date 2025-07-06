using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectrocityKomunalka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Программа для розрахування ціни за енергію");
            Console.WriteLine("Введіть кількість спожитої електроенергії в кВт*год:");
            bool Success = double.TryParse(Console.ReadLine(), out double energyUsed);
            if (!Success)
            {
                Console.WriteLine("Будь ласка, введіть коректне число.");
                return;
            }
            else if (energyUsed < 0)
            {
                Console.WriteLine("Кількість спожитої електроенергії не може бути від'ємною.");
                return;
            }

            if (energyUsed == 0)
            {
                Console.WriteLine("Ви не спожили електроенергію, тому сума до сплати дорівнює 0");
            }
            else if (energyUsed <= 100)
            {
                Console.WriteLine($"Ви спожили {energyUsed} кВт*год, за тарифом до 100 кВт*год ціна буде 1.44 грн/кВт*год, тому сума спати дорівнює: {1.44 * energyUsed}");
            }
            else if (energyUsed <= 600)
            {
                Console.WriteLine($"Ви спожили {energyUsed} кВт*год, за тарифом до 600 кВт*год ціна буде 1.68 грн/кВт*год, тому сума спати дорівнює: {1.68 * energyUsed}");
            }
            else
            {
            Console.WriteLine($"Ви спожили {energyUsed} кВт*год, за тарифом понад 600 кВт*год ціна буде 1.92 грн/кВт*год, тому сума спати дорівнює: {1.92 * energyUsed}");
            }
        }
    }
}
