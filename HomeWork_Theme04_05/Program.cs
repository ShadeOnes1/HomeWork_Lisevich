using System;

namespace HomeWork_Theme04_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");

            Console.WriteLine("Введите N: ");
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];
            
            for (int i = 0; i < n; i++)
            {
                //matrix[i] = new int[i + 1];
                for (int c = 0; c <= (n - i); c++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                    //matrix[i][j] = Fact(i) / (Fact(j) * Fact(i - j));
                    Console.Write(Fact(i) / (Fact(j) * Fact(i - j)));
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine("");
            }
        }

        static int Fact(int value)
        {
            int fact = 1;

            for(int i = 1; i <= value; i++)
            {
                fact *= i;
            }

            return fact;
        }
    }
}
