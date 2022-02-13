using System;

namespace HomeWork_Theme04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Случайная матрица");

            Console.Write("Ведите кол-во строк: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Ведите кол-во столбцов: ");
            int col = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, col];

            Random r = new Random();

            Console.WriteLine("Получившийся массив: ");

            for (int i = 0; i < row; i++)
            {
                
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = r.Next(10);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine("");
            }

            int sum = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sum += matrix[i, j];

                }

            }
            Console.WriteLine($"Сумма всех элементов массива: {sum}");
            Console.ReadKey();
        }
    }
}
