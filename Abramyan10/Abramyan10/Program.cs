using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyan10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Даны два ненулевых числа. Найти сумму, разность, произведение и частное их квадратов");
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            int s = (a * a) + (b * b);
            int r = (a * a) - (b * b);
            int p = (a * a) * (b * b);
            int c = (a * a) / (b * b);

            if (a == 0)
            {
                Console.WriteLine("Введите ненулевое число: ");
                return;
            }

            else if (b == 0)
            {
                Console.WriteLine("Введите ненулевое число: ");
                return;
            }
            else

            Console.WriteLine($"Сумма квадратов: {s}");
            Console.WriteLine($"Разность квадратов: {r}");
            Console.WriteLine($"Произведение квадратов: {p}");
            Console.WriteLine($"Частное квадратов: {c}");
        }
    }
}
