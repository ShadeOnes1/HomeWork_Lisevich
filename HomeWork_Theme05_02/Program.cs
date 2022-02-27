using System;

namespace HomeWork_Theme05_02
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
        /// Метод меняет порядок слов в предложении и выводи на экран
        /// </summary>
        /// <param name="inputPhrase"></param>
        static void ReversWords(string[] inputPhrase)
        {
            Array.Reverse(inputPhrase);

            for ( int i = 0; i < inputPhrase.Length; i++)
            {
                Console.Write($"{inputPhrase[i]} ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2. Перестановка слов в предложении");
            Console.WriteLine("Введите предложение: ");

            string sourceString = Console.ReadLine();

            string[] inputPhrase = DataSeparation(sourceString);
            ReversWords(inputPhrase);

            Console.ReadKey();
        }
    }
}
