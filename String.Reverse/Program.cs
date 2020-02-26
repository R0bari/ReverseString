using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        /// <summary>
        /// Возвращает перевернутую строку
        /// </summary>
        /// <param name="line">Исходная строка</param>
        /// <returns>Перевернутая строка</returns>
        static string Reverse(string line)
        {
            return line.Length > 1
                ? line[line.Length - 1] + Reverse(line.Substring(0, line.Length - 1))
                : line[0].ToString();

        }
        /// <summary>
        /// Возвращает строку, в которой первый символ заглавный
        /// </summary>
        /// <param name="line"></param>
        /// <returns>Строка, в которой первый символ заглавный</returns>
        static string FirstToUpper(string line)
        {
            return line.Length > 1
                ? line[0].ToString().ToUpper() + line.Substring(1, line.Length - 1)
                : line.ToUpper();
        }
        /// <summary>
        /// Возвращает строку, в которой первый символ незаглавный
        /// </summary>
        /// <param name="line"></param>
        /// <returns>Строка, в которой первый символ незаглавный</returns>
        static string FirstToLower(string line)
        {
            return line.Length > 1
                ? line[0].ToString().ToLower() + line.Substring(1, line.Length - 1)
                : line.ToLower();
        }
        static void Main()
        {
            bool repeat;
            Console.WriteLine("___Переворачивание строки___");
            do
            {
                Console.WriteLine(Environment.NewLine + "Введите произвольную строку: ");
                string startLine = Console.ReadLine().ToString();

                Console.WriteLine("Результирующая строка: " + Environment.NewLine + FirstToUpper(Reverse(FirstToLower(startLine.Trim()))));

                Console.WriteLine("Введите \"y\", чтобы повторить: ");
                repeat = Console.ReadKey().KeyChar == 'y' ? true : false;
            } while (repeat);
        }
    }
}
