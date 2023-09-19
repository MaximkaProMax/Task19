using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyan7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности: ");
            double r = double.Parse(Console.ReadLine());

            double l = 2 * 3.14 * r;
            double s = 3.14 * Math.Pow(r, 2);

            Console.WriteLine($"Длина окружности: {l}, площадь {s}");
        }
    }
}
