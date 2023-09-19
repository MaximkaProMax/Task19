using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyan15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R, S, L, P = 3.14;

            Console.Write("Введите длину (L): ");
            L = double.Parse(Console.ReadLine());
            R = L / 2 * P;
            Console.WriteLine("Радиус (R): " +R);
            S = P * Math.Pow(R, 2);
            Console.WriteLine("Площадь (S): " +S);
        }
    }
}
