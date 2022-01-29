using System;

namespace HomeWork_Theme03_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка простого числа");
            do
            {
                Console.WriteLine("Введите число для проверки");
                int n = int.Parse(Console.ReadLine());

                bool isSimple = true;

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0 && i != n)
                    {
                        isSimple = false;
                        break;
                    }
                }

                if (isSimple)
                {
                    Console.WriteLine("Число простое");
                }
                else
                {
                    Console.WriteLine("Число сложное");
                }
            }
            while (true);
        }
    }
}
