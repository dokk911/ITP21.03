using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2103Dz7
{
    class Program
    {
        //решает квадратное уравнение

        static void Main(string[] args)
        {
            double x1 = 0;
            double x2 = 0;
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            EquationSolution(ref x1, ref x2, a, b, c);

            Console.WriteLine($"Первый корень: {x1}\nВторой корень: {x2}");
            Console.ReadKey();
        }

        public static double EquationSolution(ref double x1, ref double x2, int a, int b, int c)
        {
            double d = b * b - 4 * a * c;

            if (d > 0)
            {
                d = Math.Sqrt(d);

                x1 = (-b + d) / (2 * a);
                x2 = (-b - d) / (2 * a);

            }

            return x1;
        }
    }
}
