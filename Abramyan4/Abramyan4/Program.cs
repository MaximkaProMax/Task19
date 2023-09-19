using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyan4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диаметр окружности:");
            double d = double.Parse(Console.ReadLine()); // Это радиус окружности
            double l = 3.14 * d; // Это длина окружности
            Console.WriteLine("Длина окружности: " + l);
        }
    }
}
