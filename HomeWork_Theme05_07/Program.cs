using System;

namespace HomeWork_Theme05_07
{
    class Program
    {
        static int[] InputRow()
        {
            string[] row = Console.ReadLine().Split(' ');
            int[] rowInt = new int[row.Length];
            for (int i = 0; i < row.Length; i++)
            {
                rowInt[i] = Convert.ToInt32(row[i]);
            }
            return rowInt;
        }

        static bool IsAriph(int[] rowInt)
        {
            int d = rowInt[1] - rowInt[0];
            for (int i = 1; i < rowInt.Length - 1; i++)
            {
                if (rowInt[i+1] - rowInt[i] != d)
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsGeometry(int[] rowInt)
        {
            double d = rowInt[1] / rowInt[0];
            for (int i = 1; i < rowInt.Length - 1; i++)
            {
                if (rowInt[i+1] / rowInt[i] != d)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4.");
            Console.WriteLine("Введите последовательность чисел: ");

            int[] row = InputRow();

            bool isAriph = IsAriph(row);
            bool isGeometry = IsGeometry(row);
            if (isAriph)
            {
                Console.WriteLine("Это арифмитическая прогрессия.");
            }
            else if(isGeometry)
            {
                Console.WriteLine("Это геометрическая прогрессия.");
            }
            else
            {
                Console.WriteLine("Это не прогрессия.");
            }

            Console.ReadKey();
        }
    }
}
