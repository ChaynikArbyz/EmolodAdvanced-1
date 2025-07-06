using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("--Калькулятор ціни таксі--\nЦіна за 1 км - 10 грн\nЦіна за 1 хвилину простою - 2 грн\nМінімальна ціна таксі - 50грн\n");
            Console.WriteLine("Введіть відстань у кілометрах:");

            bool distSuccess = double.TryParse(Console.ReadLine(), out double dist);
            if (!distSuccess)
            {
                Console.WriteLine("Невірний формат відстанні");
                return;
            }
            else if (dist < 0)
            {
                Console.WriteLine("Відстань не може бути від'ємною");
                return;
            }

            Console.WriteLine("Введіть час очікування у хвилинах:");
            bool timeSuccess = double.TryParse(Console.ReadLine(), out double time);
            if (!timeSuccess)
            {
                Console.WriteLine("Невірний формат часу");
                return;
            }
            else if (time < 0)
            {
                Console.WriteLine("Час не може бути від'ємним");
                return;
            }

            double price = dist * 10 + time * 2;

            if (price < 50)
            {
                Console.WriteLine($"Мінімальна ціна таксі - 50 грн, а ваша тільки {price} грн");
            }
            else
            {
                Console.WriteLine($"Ціна таксі: {price} грн");
            }

        }
    }
}
