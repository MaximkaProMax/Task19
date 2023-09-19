using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyan2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону квадрата");
            int a = int.Parse(Console.ReadLine());
            int b = a * a;

            Console.WriteLine("Площадь этого квадрата: " + b);
        }
    }
}
