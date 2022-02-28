using System;

namespace HomeWork_Theme05_04
{
    class Program
    {
        /// <summary>
        /// Метод возвращает двумерный массив 3 на 3
        /// </summary>
        /// <returns></returns>
        static int[,] GetFirstMatrix()
        {
            Random r = new Random();

            Console.WriteLine("Первая матрциа: ");

            int[,] matrix1 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix1[i, j] = r.Next(10);
                    Console.Write($"{matrix1[i, j]} ");
                }
                Console.WriteLine();
            }
            return matrix1;
        }

        /// <summary>
        /// Метод возвращает двумерный массив 3 на 3
        /// </summary>
        /// <returns></returns>
        static int[,] GetSecondMatrix()
        {
            Random r = new Random();

            Console.WriteLine("Вторая матрциа: ");

            int[,] matrix2 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix2[i, j] = r.Next(10);
                    Console.Write($"{matrix2[i, j]} ");
                }
                Console.WriteLine();
            }
            return matrix2;
        }

        /// <summary>
        /// Метод принимает два двумерных массива и вычисляет их сумму с выводом на экран результата
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        static void ResultSum(int[,] matrix1, int[,] matrix2)
        {
            Console.WriteLine("Сумма матриц: ");

            int[,] sumMatrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
                    Console.Write($"{sumMatrix[i, j]}");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Метод принимает два двумерных массива и вычисляет их произведение с выводом на экран результата
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        static void ResultComp(int[,] matrix1, int[,] matrix2)
        {
            Console.WriteLine("Произведение матриц: ");

            int[,] compMatrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    compMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
                    Console.Write($"{compMatrix[i, j]}");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.2. и 1.3.");

            int [,] firstMatrix = GetFirstMatrix();
            int [,] secondMatrix = GetSecondMatrix();
            ResultSum(firstMatrix, secondMatrix);
            ResultComp(firstMatrix, secondMatrix);

            Console.ReadKey();
        }
    }
}
