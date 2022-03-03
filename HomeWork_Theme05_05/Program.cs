using System;

namespace HomeWork_Theme05_05
{
    class Program
    {
        /// <summary>
        /// Метод разделяет строковую переменную на одномерный массив слов
        /// </summary>
        /// <param name="sourceString"></param>
        /// <returns></returns>
        static string[] DataSeparation(string sourceString)
        {
            return sourceString.Split(' ');
        }

        /// <summary>
        /// Метод находит самое длинное слово в массиве и выводит его на экран
        /// </summary>
        /// <param name="arrayString"></param>
        static void OutputLargestWord(string[] arrayString)
        {
            int symbolsCount = 0;
            string largestWord = arrayString[0];
            for (int i = 1; i < arrayString.Length; i++)
            {
                if (arrayString[i].Length >= symbolsCount)
                {
                    symbolsCount = arrayString[i].Length;
                    largestWord = arrayString[i];
                }
            }
            Console.WriteLine($"Самое длинное слово: {largestWord}.");
        }

        /// <summary>
        /// Метод находит самое короткое слово в массиве и выводит его на экран
        /// </summary>
        /// <param name="arrayString"></param>
        static void OutputSmallestWord(string[] arrayString)
        {
            int symbolsCount = int.MaxValue;
            string smallestWord = arrayString[0];
            for (int i = 1; i < arrayString.Length; i++)
            {
                if (arrayString[i].Length <= symbolsCount)
                {
                    symbolsCount = arrayString[i].Length;
                    smallestWord = arrayString[i];
                }
            }
            Console.WriteLine($"Самое короткое слово: {smallestWord}.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2.");
            Console.WriteLine("Введите предложение: ");

            string sourceString = Console.ReadLine();

            string[] arrayString = DataSeparation(sourceString);
            OutputLargestWord(arrayString);
            OutputSmallestWord(arrayString);

            Console.ReadKey();
        }
    }
}
