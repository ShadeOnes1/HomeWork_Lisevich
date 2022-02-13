using System;

namespace HomeWork_Theme04_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3. Игра «Угадай число»");

            Console.WriteLine("Введите максимальное число диапазона: ");
            int max = int.Parse(Console.ReadLine());

            Random r = new Random();
            int value = r.Next(0, max);

            bool n = true;

            do
            {
                Console.WriteLine("Попробуйте угадать число: ");

                int numb = 0;
                string numbText = Console.ReadLine();

                if (int.TryParse(numbText, out int num))
                {
                    numb = num;
                }
                else
                {
                    n = false;
                }

                if (numb < value)
                {
                    Console.WriteLine("Введенное число меньше загаданного!");
                }
                else if (numb > value)
                {
                    Console.WriteLine("Введенное число больше загаданного!");
                }
                else 
                {
                    Console.WriteLine("Поздравляю, число угадано!");
                    n = false;
                }
            } while (n);
            Console.WriteLine($"Загаданное число: {value}");
            Console.ReadKey();
        }
    }
}
