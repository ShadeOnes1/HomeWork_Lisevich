using System;

namespace HomeWork_Theme05_06
{
    class Program
    {
        static void ProcessRow(string[] inputString)
        {
            for  (int i = 0; i < inputString.Length; i++)
            {
                Console.Write(ProcessWord(inputString[i]) + " ");
            }
        }

        static string ProcessWord(string inputString)
        {
            string resultWord = "";

            resultWord += inputString[0];

            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if (inputString[i] != inputString[i + 1])
                {
                    resultWord += inputString[i + 1];
                }
            }

            return resultWord;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите строку: ");

            string[] inputString = Console.ReadLine().Split(' ');

            ProcessRow(inputString);

            Console.ReadKey();
        }
    }
}
