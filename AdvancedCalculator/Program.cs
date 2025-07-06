using System;
using System.Collections.Generic;
using System.Text;
using AdvancedCalculator.Operations;

namespace AdvancedCalculator
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            List<BaseOperation> operations = new List<BaseOperation>
            {
                new PlusOperation(),
                new MinusOperation(),
                new MnozenyaOperation(),
                new DilenyaOperation(),
                new KorinOperation(),
                new StepinOperation()
            };

            Console.WriteLine("-- Продвинутий калькулятор --");
            Console.WriteLine("Введіть номер дії\n1 - додавання 2 - віднімання 3 - множення 4 - ділення 5 - корінь 6 - степінь");


            bool success = int.TryParse(Console.ReadLine(), out int operation);
            if (!success || operation < 1 || operation > operations.Count)
            {
                Console.WriteLine("Невірний номер дії. Будь ласка, спробуйте ще раз.");
                return;
            }


            BaseOperation selectedOperation = operations[operation - 1];

            selectedOperation.Use();
        }
    }
}
