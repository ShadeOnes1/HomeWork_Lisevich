using System;

namespace HomeWork_Theme03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа подсчёта суммы карт в игре «21»!");
            Console.WriteLine("Введите кол-во карт в руке.");
            int cardCount = int.Parse(Console.ReadLine());

            int cardSum = 0;

            for (int i = 0; i < cardCount; i++)
            {
                Console.Write($"Введите {i + 1} карту: ");
                string cardValueText = Console.ReadLine();
                if (int.TryParse(cardValueText, out int cardValue))
                {
                    cardSum += cardValue;
                }
                else
                {
                    switch (cardValueText)
                    {
                        case "Валет":
                        case "J":
                        case "j":
                            cardSum += 2;
                            break;
                        case "Дама":
                        case "Q":
                        case "q":
                            cardSum += 3;
                            break;
                        case "Король":
                        case "K":
                        case "k":
                            cardSum += 4;
                            break;
                        case "Туз":
                        case "T":
                        case "t":
                            cardSum += 1;
                            break;
                    }
                }
            }
            Console.WriteLine($"Сумма карт: {cardSum}");
            Console.ReadLine();
        }
    }
}
