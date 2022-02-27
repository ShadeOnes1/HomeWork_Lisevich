using System;

namespace HomeWork_Theme05_01
{
    class Program
    {
        /// <summary>
        /// Метод разделяет предложение на слова
        /// </summary>
        /// <param name="sourceString"></param>
        /// <returns></returns>
        static string[] DataSeparation(string sourceString) 
        {
            return sourceString.Split(' ');
        }

        /// <summary>
        /// Метод выводящий слова построчно
        /// </summary>
        /// <param name="separatedString"></param>
        static void Output(string[] separatedString)
        {
            for (int i = 0; i < separatedString.Length; i++)
            {
                Console.WriteLine($"{separatedString[i]}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Метод разделения строки на слова");
            Console.WriteLine("Введите предложение: ");

            string sourceString = Console.ReadLine();

            string[] separatedString = DataSeparation(sourceString);
            Output(separatedString);

            Console.ReadKey();
        }
    }
}
