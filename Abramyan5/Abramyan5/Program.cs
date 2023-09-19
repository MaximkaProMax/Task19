using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyan5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер ребра куба: "); 
            double a = double.Parse(Console.ReadLine());
            double v = Math.Pow(a, 3); // объем куба
            double s = 6 * Math.Pow(a, 2); // площадь поверхности куба
            Console.WriteLine("Объем куба: " + v);
            Console.WriteLine("Площадь поверхности куба: " + s);
        }
    }
}
