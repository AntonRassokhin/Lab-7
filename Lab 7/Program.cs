using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {

            int V, S;
            Console.Write("Введите длину ребра куба: ");
            int a = Convert.ToInt32(Console.ReadLine());
            getKotlet(a, out V, out S);

            Console.WriteLine("Объем - {0:0,0}", V);
            Console.WriteLine("Площадь поверхности - {0:0,0}", S);
            Console.ReadKey();
        }

        static void getKotlet(int a, out int V, out int S)
        {
            V = a * a * a;
            S = a * a * 6;
        }

    }
}
