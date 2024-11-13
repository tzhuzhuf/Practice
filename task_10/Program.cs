using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            bool isCorrectInput = true;
            Console.Write("Введите число, процент которого хотите посчитать: ");

            double value;
            if (double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine(value * 0.01);
            }
            else
            {
                isCorrectInput = false;

                Console.WriteLine("Некорректный ввод! Хотите продолжить? Y/N");

                while (true)
                {
                    ConsoleKey choice = Console.ReadKey(true).Key;

                    switch (choice)
                    {
                        case ConsoleKey.Y:
                            Console.Clear();
                            break;
                        case ConsoleKey.N:
                            return;
                        default:
                            continue;
                    }
                    break;
                }
            }
            if (isCorrectInput)
            {
                Console.WriteLine("Нажмите Escape для выхода или любую другую клавишу для повторного запуска...");

                ConsoleKey choice2 = Console.ReadKey(true).Key;

                switch (choice2)
                {
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        continue;
                }
            }
        }
    }
}