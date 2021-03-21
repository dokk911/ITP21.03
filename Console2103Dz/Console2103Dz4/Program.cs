using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2103Dz4
{
    class Program
    {
        //считает сумму нечетных чисел, находящихся в строке

        static void Main(string[] args)
        {
            int sum = 0;
            string text = Console.ReadLine();

            SumOfOdd(ref sum, text);

            Console.WriteLine(sum);
            Console.ReadKey();
        }

        public static int SumOfOdd(ref int sum, string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]) == true)
                {
                    if (text[i] % 2 != 0)
                    {
                        sum += Convert.ToInt32(char.IsDigit(text[i]));
                    }
                }
            }

            return sum;
        }
    }
}
