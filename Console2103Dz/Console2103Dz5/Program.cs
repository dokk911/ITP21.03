using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2103Dz5
{
    //проводить зашифрование методом Цезаря

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сообщение: ");
            string message = Console.ReadLine();

            message = message.ToLower();

            Console.Write("Введите шаг: ");
            int step = int.Parse(Console.ReadLine());

            string newMessage = CaesarCipher(message, step);

            Console.WriteLine($"Зашифрованное сообщение: {newMessage}");

            string newNewMessage = CaesarCipher(newMessage, 33 - step);

            Console.WriteLine($"Дешифрованное сообщение: {newNewMessage}");

            Console.ReadKey();
        }

        public static string CaesarCipher(string message, int step)
        {
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            string newMessage = string.Empty;

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == ' ')
                {
                    newMessage += ' ';
                    continue;
                }

                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (message[i] == alphabet[j])
                    {
                        newMessage += alphabet[(j + step) % alphabet.Length];
                    }
                }
            }

            return newMessage;
        }
    }
}
