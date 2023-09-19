using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyan11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число"); 
            int a = int.Parse(Console.ReadLine()); // первое число
            Console.WriteLine("Введите второе число");
            int b = int.Parse(Console.ReadLine()); // второе число

            if (a < 0) // Модуль же вроде делает всё положительным хз
            {
                a = a * -1;
            }

            if (b < 0)
            {
                b = b * -1;
            }


            int s = a + b; // сумма модулей чисел
            int p = (a * b); // произведение чисел
            int c = a / b; // частное чисел
            int r = a - b; // разность от деления

            Console.WriteLine("Сумма модуля: " + s);
            Console.WriteLine("Произведение: " + p);
            Console.WriteLine("Частное: " + c);
            Console.WriteLine("Разность: " + r);
        }
    }
}
