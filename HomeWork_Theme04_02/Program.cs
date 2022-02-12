using System;

namespace HomeWork_Theme04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2. Наименьший элемент в последовательности.");

            Console.WriteLine("Ведите длинну последовательности: ");
            int size = int.Parse(Console.ReadLine());

            int[] numbs = new int[size];

            int min = int.MaxValue;

            for (int i = 0; i < numbs.Length; i++)
            {
                Console.WriteLine("Введите число для заполнения элемента: ");
                numbs[i] = int.Parse(Console.ReadLine());
                if (min > numbs[i])
                {
                    min = numbs[i];
                }
            }

            Console.WriteLine("Получившийся массив: ");
            for (int i = 0; i < numbs.Length; i++)
            {
                Console.Write($"{numbs[i]} ");
            }

            Console.WriteLine();

            Console.WriteLine($"Наименьшее число: {min}");
            Console.ReadKey();
        }
    }
}
