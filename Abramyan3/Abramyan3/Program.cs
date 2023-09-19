using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyan3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую сторону прямоугольника: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону прямоугольника: ");
            int b = int.Parse(Console.ReadLine());

            int s = a * b;
            int p = 2 * (a + b);

            Console.WriteLine($"Площадь прямоугольника: {s}, а его периметр: {p}");

        }
    }
}
