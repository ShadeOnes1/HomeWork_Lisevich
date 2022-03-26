using System;
using System.Text;
using System.IO;

namespace HomeWork_Theme06_01
{
    class Program
    {
        static void Input()
        {
            using (StreamWriter sw = new StreamWriter("data.txt", true))
            {
                char key = '2';
                int ID = 0;

                do
                {
                    string note = string.Empty;

                    ID = ID + 1;
                    note += $"{ID}#";

                    Console.Write("\nВведите ФИО сотрудника ");
                    note += $"{Console.ReadLine()}#";

                    string now = DateTime.Now.ToString();
                    Console.WriteLine($"\nДата добавления записи {now}");
                    note += $"{now}#";

                    Console.Write("\nВведите возраст сотрудника ");
                    note += $"{Console.ReadLine()}#";

                    Console.Write("\nВведите рост сотрудника ");
                    note += $"{Console.ReadLine()}#";

                    Console.Write("\nВведите дату рождения сотрудника ");
                    note += $"{Console.ReadLine()}#";

                    Console.Write("\nВведите место рождения сотрудника ");
                    note += $"{Console.ReadLine()}#";

                    sw.WriteLine(note);
                    Console.Write("Продожить 1/2?"); key = Console.ReadKey(true).KeyChar;
                } while (char.ToLower(key) == '2');
            }
        }

        static void Read()
        {
            using (StreamReader sr = new StreamReader("data.csv"))
            {
                string line;
                Console.WriteLine($"{"ID"}{"ФИО"}{"Дата"}{"Возраст"}{"Рост"}{"Дата рождения"}{"Место рождения"}");

                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('#');
                    Console.WriteLine($"{data[0]}{data[1]}{data[2]}{data[3]}{data[4]}{data[5]}{data[6]}");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Сотрудники");


        }
    }
}
