using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyan17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Даны три точки A, B, C на числовой оси. Найти длины отрезков AC и BC и их сумму.");
            Console.Write("Введите точку A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите точку B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите точку C: ");
            double c = double.Parse(Console.ReadLine());

            double ac = c - a;
            double bc = c - b;
            double sum = ac + bc;

            Console.WriteLine("Длина отрезка AC: " + ac);
            Console.WriteLine("Длина отрезка BC: " + bc);
            Console.WriteLine("Сумма отрезков: " + sum);
        }
    }
}
