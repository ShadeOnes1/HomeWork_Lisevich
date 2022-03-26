using System;
using System.Text;
using System.IO;

namespace HomeWork_Theme06_01
{
    class Program
    {
        static void Input(int ID)
        {

            using (StreamWriter sw = new StreamWriter("data.txt", true))
            {
                string note = string.Empty;

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

            bool isExitInput = false;

            int ID = 1;

            while (!isExitInput)
            {
                Console.WriteLine("Команды:\n1 - Чтение из файла;\n2 - Запись в файл;\n <любой символ> - выход");
                string inputedLine = Console.ReadLine();

                switch (inputedLine)
                {
                    case "1":
                        Read();
                        break;
                    case "2":
                        Input(ID);
                        ID++;
                        break;
                    default:
                        isExitInput = true;
                        break;
                }
            }
        }
    }    
}
