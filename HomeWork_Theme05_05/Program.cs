using System;

namespace HomeWork_Theme05_05
{
    class Program
    {
        static string[] DataSeparation(string sourceString)
        {
            return sourceString.Split(' ');
        }

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
