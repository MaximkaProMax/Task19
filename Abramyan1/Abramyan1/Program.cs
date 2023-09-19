using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyan1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите одну из 4 сторон квадрата: ");
            int a = int.Parse(Console.ReadLine());
            int b = a * 4;

            Console.WriteLine("Периметр этого квадрата равен " + b);
        }
    }
}
