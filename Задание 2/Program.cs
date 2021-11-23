using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double S1, S2;
            Console.WriteLine("Введите 3 стороны первого треугольника:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            calcul(a, b, c, out S1);

            Console.WriteLine("Введите 3 стороны второго треугольника:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            calcul(a, b, c, out S2);

            if (S1 == S2)
            {
                Console.WriteLine("Площади треугольников равны");
            }
            else
            {
                if (S1 > S2)
                {
                    Console.WriteLine("Площадь первого треугольника больше");
                }
                else
                {
                    Console.WriteLine("Площадь второго треугольника больше");
                }

            }
            Console.ReadKey();

        }
        static void calcul(double a, double b, double c, out double S)
        {
            double pP = (a + b + c) / 2;
            S = Math.Sqrt(pP * (pP - a) * (pP - b) * (pP - c));
            Console.WriteLine("Полупериметр -{0:F2} , площадь -{1:F2}", pP, S); ///для проверки
        }

    }
}
