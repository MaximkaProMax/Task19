using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyan6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер первого ребра куба: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите размер второго ребра куба: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите размер третьего ребра куба: ");
            double c = double.Parse(Console.ReadLine());


            double v = a * b * c; // объем куба
            double s = 2 * (a * b + b * c + c * a); // площадь поверхности куба
            Console.WriteLine("Объем куба: " + v);
            Console.WriteLine("Площадь поверхности куба: " + s);
        }
    }
}
