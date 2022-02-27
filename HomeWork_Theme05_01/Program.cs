using System;

namespace HomeWork_Theme05_01
{
    class Program
    {
        static string[] DataSeparation(string sourceString) 
        {
            return sourceString.Split(' ');
        }

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
