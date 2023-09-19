using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyan16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую точку на оси (x1): ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите вторую точку на оси (x2): ");
            double x2 = double.Parse(Console.ReadLine());

            double a = x2 - x1;
            Console.WriteLine("Расстояние между точками: " + a);
        }
    }
}
