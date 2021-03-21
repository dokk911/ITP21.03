using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2103Dz3
{
    class Program
    {
        //вырезает из строковой перемены буквы

        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            CuttingLetters(ref text);

            Console.WriteLine(text);
            Console.ReadKey();
        }

        public static void CuttingLetters(ref string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]) == true)
                {
                    text = text.Remove(i, 1);
                    i--;
                }
            }
        }
    }
}
