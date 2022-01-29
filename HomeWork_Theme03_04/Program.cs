using System;

namespace HomeWork_Theme03_04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            // Просматривая сайты по поиску работы, у вас вызывает интерес следующая вакансия:

            // Требуемый опыт работы: без опыта
            // Частичная занятость, удалённая работа
            //
            // Описание 
            //
            // Стартап «Micarosppoftle» занимающийся разработкой
            // многопользовательских игр ищет разработчиков в свою команду.
            // Компания готова рассмотреть C#-программистов не имеющих опыта в разработке, 
            // но желающих развиваться в сфере разработки игр на платформе .NET.
            //
            // Должность Интерн C#/
            //
            // Основные требования:
            // C#, операторы ввода и вывода данных, управляющие конструкции 
            // 
            // Конкурентным преимуществом будет знание процедурного программирования.
            //
            // Не технические требования: 
            // английский на уровне понимания документации и справочных материалов
            //
            // В качестве тестового задания предлагается решить следующую задачу.
            //
            // Написать игру, в которою могут играть два игрока.
            // При старте, игрокам предлагается ввести свои никнеймы.
            // Никнеймы хранятся до конца игры.
            // Программа загадывает случайное число gameNumber от 12 до 120 сообщая это число игрокам.
            // Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
            // Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
            // введенное число вычитается из gameNumber
            // Новое значение gameNumber показывается игрокам на экране.
            // Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
            // Игра поздравляет победителя, предлагая сыграть реванш
            // 
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

            // *** Сложный бонус
            // Подумать над возможностью реализации однопользовательской игры
            // т е игрок должен играть с компьютером


            // Демонстрация
            // Число: 12,
            // Ход User1: 3
            //
            // Число: 9
            // Ход User2: 4
            //
            // Число: 5
            // Ход User1: 2
            //
            // Число: 3
            // Ход User2: 3
            //
            // User2 победил!
            #endregion

            Console.WriteLine("Выберите режим игры. 1 - Классический, 2 - Редактируемый, 3 - Одиночная.");
            int difficulty = Convert.ToInt32(Console.ReadLine());
            if (difficulty == 1)
            {
                Console.WriteLine("Игрок 1 введите свой никнейм:");
                string nickname1 = Console.ReadLine();

                Console.WriteLine("Игрок 2 введите свой никнейм:");
                string nickname2 = Console.ReadLine();

                Random rand = new Random();
                int gameNumber = rand.Next(12, 121);
                Console.WriteLine($"Случайное число: {gameNumber} ");

                bool isPlayer0Turn = true;

                do
                {
                    string playerNickname = isPlayer0Turn ? nickname1 : nickname2;

                    Console.WriteLine($"Ход игрока {playerNickname }. Введите число от 1 до 4.");
                    int userTry = Convert.ToInt32(Console.ReadLine());

                    gameNumber = gameNumber - userTry;

                    isPlayer0Turn = !isPlayer0Turn;

                    if (gameNumber <= 0)
                    {
                        gameNumber = 0;
                    }
                    else
                    {
                        Console.WriteLine($"Новое игровое число: {gameNumber}");
                    }

                } while (gameNumber != 0);

                Console.WriteLine("0 достигнут!");

                string winnerNickname = isPlayer0Turn ? nickname2 : nickname1;
                Console.WriteLine($"Победил игрок {winnerNickname}!");
            }
            else if (difficulty == 2)
            {
                Console.WriteLine("Введите количество игроков:");
                int playerCount = Convert.ToInt32(Console.ReadLine());

                string[] playerNicknames = new string[playerCount];

                int i = 0;
                do
                {
                    Console.WriteLine($"Введите никнейм #{i + 1} игрока:");
                    playerNicknames[i] = Console.ReadLine();
                    i++;
                }
                while (i < playerCount);

                Console.WriteLine("Введите нижнюю границу игрового числа");
                int lowerNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите верхнюю границу игрового числа");
                int upperNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите нижнюю границу вычитаемого числа");
                int lowerUserTry = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите вверхнюю границу вычитаемого числа");
                int upperUserTry = Convert.ToInt32(Console.ReadLine());

                // TODO: values range here

                Random rand = new Random();
                int gameNumber = rand.Next(lowerNumber, upperNumber);
                Console.WriteLine($"Случайное число: {gameNumber} ");

                int currentPlayerIndex = -1;

                do
                {
                    currentPlayerIndex++;

                    if (currentPlayerIndex >= playerCount)
                    {
                        currentPlayerIndex = 0;
                    }

                    Console.WriteLine($"Ход игрока { playerNicknames[currentPlayerIndex] }.");

                    int userTry = 0;
                    bool isUserTryCorrect = false;

                    do
                    {
                        Console.WriteLine("Введите вычитаемое число: ");
                        userTry = Convert.ToInt32(Console.ReadLine());

                        isUserTryCorrect = userTry >= lowerUserTry && userTry <= upperUserTry;

                        if (!isUserTryCorrect)
                        {
                            Console.WriteLine("Число вне промежутка! Введите корректное число.");
                        }
                    }
                    while (!isUserTryCorrect);

                    gameNumber = gameNumber - userTry;

                    if (gameNumber <= 0)
                    {
                        gameNumber = 0;
                    }
                    else
                    {
                        Console.WriteLine($"Новое игровое число: {gameNumber}");
                    }

                } while (gameNumber != 0);

                Console.WriteLine("0 достигнут!");
                Console.WriteLine($"Победил игрок под ником: { playerNicknames[currentPlayerIndex] }.");
            }
            else if (difficulty == 3)
            {
                Console.WriteLine("Выбран режим против кудахтера.");

                Console.WriteLine("Игрок, введите свой никнейм:");
                string nickname = Console.ReadLine();

                Console.WriteLine("Введите нижнюю границу игрового числа");
                int lowerNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите верхнюю границу игрового числа");
                int upperNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите нижнюю границу вычитаемого числа");
                int lowerUserTry = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите вверхнюю границу вычитаемого числа");
                int upperUserTry = Convert.ToInt32(Console.ReadLine());

                Random rand = new Random();
                int gameNumber = rand.Next(lowerNumber, upperNumber);
                Console.WriteLine($"Случайное число: {gameNumber} ");

                bool isPlayersTurn = true;

                do
                {
                    int userTry = 0;

                    if (isPlayersTurn)
                    {
                        Console.WriteLine($"Ход игрока {nickname}.");

                        bool isUserTryCorrect = false;

                        do
                        {
                            Console.WriteLine("Введите вычитаемое число: ");
                            userTry = Convert.ToInt32(Console.ReadLine());

                            isUserTryCorrect = userTry >= lowerUserTry && userTry <= upperUserTry;

                            if (!isUserTryCorrect)
                            {
                                Console.WriteLine("Число вне промежутка! Введите корректное число.");
                            }
                        }
                        while (!isUserTryCorrect);
                    }
                    else
                    {
                        Console.WriteLine("Ход компьютера.");
                        userTry = rand.Next(lowerUserTry, upperUserTry);
                        Console.WriteLine($"Число компьютера: {userTry}");
                    }

                    gameNumber = gameNumber - userTry;

                    isPlayersTurn = !isPlayersTurn;

                    if (gameNumber <= 0)
                    {
                        gameNumber = 0;
                    }
                    else
                    {
                        Console.WriteLine($"Новое игровое число: {gameNumber}");
                    }

                } while (gameNumber != 0);

                Console.WriteLine("0 достигнут!");

                string winnerNickname = isPlayersTurn ? "компьютер" : nickname;
                Console.WriteLine($"Победил игрок {winnerNickname}!");
            }
            else
            {
                Console.WriteLine("Некорректный режим.");
            }

            Console.ReadKey();
        }
    }
}
