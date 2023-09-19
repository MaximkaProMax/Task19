using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Abramyan13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первый радиус: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите второй радиус (меньше предыдущего): ");
            double b = double.Parse(Console.ReadLine());

            double s1 = 3.14 * a * a;
            double s2 = 3.14 * b * b;
            double s3 = s1 - s2;

            if (a <= b)
            {
                Console.Write("Первый радиус должен быть больше второго!");
                return;
            }
            else
            {

            }

            Console.WriteLine("Площадь первого круга: " + s1);
            Console.WriteLine("Площадь второго круга: " + s2);
            Console.WriteLine("Площадь кольца: " + s3);




        }
    }
}
