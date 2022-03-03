using System;

namespace HomeWork_Theme05_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 5");
            Console.WriteLine("Вычисление функции Аккермана при A(2, 5), A(1, 2).");

            int m = 2, n = 5;
            Console.WriteLine($"А(2, 5) = {ResultFunc(m, n)}");

            int k = 1, l = 2;
            Console.WriteLine($"А(1, 2) = {ResultFunc(k, l)}");
        }

        /// <summary>
        /// Метод принимает два числа и возвращает число посчитанное по функции Аккермана
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static int ResultFunc(int m, int n)
        {
            if (m > 0 && n == 0)
            {
                return ResultFunc(m - 1, 1);
            } 
            else if (m > 0 && n > 0)
            {
                return ResultFunc(m - 1, ResultFunc(m, n - 1));
            }
            else
            {
                return n + 1;
            }
        }
    }
}
