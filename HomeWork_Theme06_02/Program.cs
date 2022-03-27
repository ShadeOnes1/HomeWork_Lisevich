using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace HomeWork_Theme06_02
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Свойства делимости чисел");

            bool isExitInput = false;

            while (!isExitInput)
            {
                Console.WriteLine("\nКоманды:\n1 - Вывод M;\n2 - Полный вывод;\n <любой символ> - выход");
                string inputedLine = Console.ReadLine();

                DateTime firstDate = DateTime.Now;
                DateTime secondDate = DateTime.Now;

                switch (inputedLine)
                {
                    case "1":
                        PrintGroupNumber();
                        secondDate = DateTime.Now;
                        break;
                    case "2":
                        PrintAllInfo();
                        ArchiveInfoDialog();
                        secondDate = DateTime.Now;
                        break;
                    default:
                        isExitInput = true;
                        break;
                }

                TimeSpan processTime = secondDate - firstDate;
                Console.WriteLine("Выполнено за: ~ {0:f0} секунд или {1:f0} миллисекунд", processTime.TotalSeconds, processTime.TotalMilliseconds);
            }

        }

        /// <summary>
        /// Заполнение ячеек масива
        /// </summary>
        /// <param name="N"></param>
        /// <param name="M"></param>
        /// <returns></returns>
        static List<List<int>> CalculateRow(int N, int M)
        {
            List<List<int>> myList = new List<List<int>>();

            for(int i = 0; i < M; i++)
            {
                myList.Add(new List<int>());
            }
            
            for(int i = 1; i <= N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if(!DividedAny(i, myList[j]))
                    {
                        myList[j].Add(i);
                        break;
                    }
                }
            }

            return myList;
        }

        /// <summary>
        /// Проверка делимости числа на какое либо число из списка без остатка
        /// </summary>
        /// <param name="value"></param>
        /// <param name="group"></param>
        /// <returns></returns>
        static bool DividedAny(int value, List<int> group)
        {
            for(int i = 0; i < group.Count; i++)
            {
                if(value % group[i] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Чтение N из файла
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static string ReadN(string path)
        {
            string readedLine = "";

            using (StreamReader sr = new StreamReader(path))
            {
                readedLine = sr.ReadLine();
            }

            return readedLine;
        }

        /// <summary>
        /// Вывод кол-ва групп
        /// </summary>
        static void PrintGroupNumber()
        {
            Console.WriteLine("Введите путь к файлу с N: ");

            string path = Console.ReadLine();

            int N;

            bool isSuccessFormat = int.TryParse(ReadN(path), out N);

            if (N <= 1_000_000_000 && isSuccessFormat)
            {
                int M = (int)Math.Log(N, 2) + 1;
                Console.WriteLine($"Кол-во групп = {M}");
            }
            else
            {
                Console.WriteLine("Некоректное число. Проверьте файл.");
            }
        }

        /// <summary>
        /// Вывод всей информации
        /// </summary>
        static void PrintAllInfo()
        {
            Console.WriteLine("Введите путь к файлу с N: ");

            string path = Console.ReadLine();

            int N;

            bool isSuccessFormat = int.TryParse(ReadN(path), out N);

            if (N <= 1_000_000_000 && isSuccessFormat)
            {
                int M = (int)Math.Log(N, 2) + 1;
                List<List<int>> myList = CalculateRow(N, M);
                CreateFileInfo(myList);
                Console.WriteLine("Данные записаны в файл Info.txt");
            }
            else
            {
                Console.WriteLine("Некоректное число. Проверьте файл.");
            }
        }

        /// <summary>
        /// Создание файла со всей информацией
        /// </summary>
        /// <param name="myList"></param>
        static void CreateFileInfo(List<List<int>> myList)
        {
            using (StreamWriter sw = new StreamWriter("Info.txt"))
            {
                for(int i = 0; i < myList.Count; i++)
                {
                    for (int j = 0; j < myList[i].Count; j++)
                    {
                        sw.Write(myList[i][j] + " ");
                    }

                    sw.WriteLine();
                }
            }
        }

        /// <summary>
        /// Вывод диалога об архивации результатов
        /// </summary>
        static void ArchiveInfoDialog()
        {
            bool isExitInput = false;

            while (!isExitInput)
            {
                Console.WriteLine("Заархивировать? \n 1 - Да \n <любой символ> - Нет");
                string inputedLine = Console.ReadLine();

                switch (inputedLine)
                {
                    case "1":
                        Archivate();
                        Console.WriteLine("Архивация прошла успешно. Архив Info.zip");
                        isExitInput = true;
                        break;
                    default:
                        isExitInput = true;
                        break;
                }
            }
        }
        
        /// <summary>
        /// Архивация
        /// </summary>
        static void Archivate()
        {
            string source = "Info.txt";
            string compressed = "Info.zip";

            using (FileStream ss = new FileStream(source, FileMode.OpenOrCreate))
            {
                using (FileStream ts = File.Create(compressed))   
                {
                    using (GZipStream cs = new GZipStream(ts, CompressionMode.Compress))
                    {
                        ss.CopyTo(cs); 
                    }
                }
            }
        }
    }

    /// Домашнее задание
    ///
    /// Группа начинающих программистов решила поучаствовать в хакатоне с целью демонстрации
    /// своих навыков. 
    /// 
    /// Немного подумав они вспомнили, что не так давно на занятиях по математике
    /// они проходили тему "свойства делимости целых чисел". На этом занятии преподаватель показывал
    /// пример с использованием фактов делимости. 
    /// Пример заключался в следующем: 
    /// Написав на доске все числа от 1 до N, N = 50, преподаватель разделил числа на несколько групп
    /// так, что если одно число делится на другое, то эти числа попадают в разные руппы. 
    /// В результате этого разбиения получилось M групп, для N = 50, M = 6
    /// 
    /// N = 50
    /// Группы получились такими: 
    /// 
    /// Группа 1: 1
    /// Группа 2: 2 3 5       7           11          13      17      19        23      29   31   37   41   43   47
    /// Группа 3: 4    6   9   10      14  15  21  22      25  26  33  34  35  38   39   46  49
    /// Группа 4: 8    12  18  20  27  28  30  42  44  45  50
    /// Группа 5: 16   24  36  40
    /// Группа 6: 32   48
    /// 
    /// M = 6
    /// 
    /// ===========
    /// 
    /// N = 10
    /// Группы получились такими: 
    /// 
    /// Группа 1:       1
    /// Группа 2:       2      7  9
    /// Группа 3:    3  4  10
    /// Группа 4: 5  6  8
    /// 
    /// M = 4
    /// 
    /// Участники хакатона решили эту задачу, добавив в неё следующие возможности:
    /// 1. Программа считыват из файла (путь к которому можно указать) некоторое N, 
    ///    для которого нужно подсчитать количество групп
    ///    Программа работает с числами N не превосходящими 1 000 000 000
    ///   
    /// 2. В ней есть два режима работы:
    ///   2.1. Первый - в консоли показывается только количество групп, т е значение M
    ///   2.2. Второй - программа получает заполненные группы и записывает их в файл используя один из
    ///                 вариантов работы с файлами
    ///            
    /// 3. После выполения пунктов 2.1 или 2.2 в консоли отображается время, за которое был выдан результат 
    ///    в секундах и миллисекундах
    /// 
    /// 4. После выполнения пунта 2.2 программа предлагает заархивировать данные и если пользователь соглашается -
    /// делает это.
    /// 
    /// Попробуйте составить конкуренцию начинающим программистам и решить предложенную задачу
    /// (добавление новых возможностей не возбраняется)
    ///
    /// * При выполнении текущего задания, необходимо документировать код 
    ///   Как пометками, так и xml документацией
    ///   В обязательном порядке создать несколько собственных методов
}
