using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2103Dz10
{
    class Program
    {
        //подсчитывает кол - во дней до Нового Года

        static void Main(string[] args)
        {
            int days = 0;
            string date = Console.ReadLine();
            string[] words = date.Split(new char[] { '/' });

            CountingDays(ref days, words);

            Console.WriteLine(days);
            Console.ReadKey();
        }

        public static int CountingDays(ref int days, string[] words)
        {
            int daysNewYear = 365;
            int day = Convert.ToInt32(words[0]);
            int month = Convert.ToInt32(words[1]);
            int year = Convert.ToInt32(words[2]);

            switch (month)
            {
                case 1:
                    days = 0 + day;
                    break;
                case 2:
                    days = 31 + day;
                    break;
                case 3:
                    days = 59 + day;
                    break;
                case 4:
                    days = 90 + day;
                    break;
                case 5:
                    days = 120 + day;
                    break;
                case 6:
                    days = 151 + day;
                    break;
                case 7:
                    days = 181 + day;
                    break;
                case 8:
                    days = 212 + day;
                    break;
                case 9:
                    days = 243 + day;
                    break;
                case 10:
                    days = 273 + day;
                    break;
                case 11:
                    days = 304 + day;
                    break;
                case 12:
                    days = 334 + day;
                    break;
            }

            if (year % 4 == 0)
            {
                daysNewYear = 366;
            }

            days = daysNewYear - days;

            return days;
        }
    }
}
