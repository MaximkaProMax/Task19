using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyan12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первый катет прямоугольного треугольника: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите второй катет прямоугольного треугольника: ");
            double b = double.Parse(Console.ReadLine());

            double c = (double)Math.Sqrt(a * a + b * b);
            double p = a + b + c;

            Console.WriteLine($"Гипотенуза: {c}");
            Console.WriteLine($"Гипотенуза: {p}");
        }
    }
}
