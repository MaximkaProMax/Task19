using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyan14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину окружности: ");
            double l = double.Parse(Console.ReadLine());

            double r = l / 2 * 3.14;
            double s = 3.13 * r * r;

            Console.WriteLine($"Площадь окружности: {s}, радиус: {r}");   
        }
    }
}
