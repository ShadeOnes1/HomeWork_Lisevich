using System;

namespace HomeWork_Theme03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приложение по определению чётного или нечётного числа");
            do
            {
                Console.WriteLine("Введите число для проверки.");
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine("Число четное");
                }
                else
                {
                    Console.WriteLine("Число нечетное");
                }
            }
            while (true);
        }
    }
}
