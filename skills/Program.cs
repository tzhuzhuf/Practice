using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread keyChecker = new Thread(IsKeyPressed);
        keyChecker.Start();

        Console.WriteLine("Введите конец диапазона для простых чисел, которые нужно вывести (для закрытия программы - нажмите Escape): ");
        int endOfRange;
        bool isSimple;

        while (true)
        {
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                else if (keyInfo.Key == ConsoleKey.Q)
                {
                    Console.Clear();
                    Console.WriteLine("Консоль очищена. Введите новый конец диапазона или нажмите Escape для выхода:");
                }
            }

            // Теперь запрашиваем ввод числа
            Console.Write("Введите число: ");
            if (int.TryParse(Console.ReadLine(), out endOfRange))
            {
                Console.Write($"Все простые числа от 1 до {endOfRange}: ");
                for (int i = 2; i <= endOfRange; i++)
                {
                    isSimple = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isSimple = false;
                            break;
                        }
                    }
                    if (isSimple)
                        Console.Write(i + " ");
                }
                Console.WriteLine("\n\nВведите новый конец диапазона: \nВыйти - Escape\nОчистка консоли - \"Q\"");
            }
            else
            {
                Console.Clear();
                Console.Write("Некорректный ввод! Попробуйте ещё раз (для закрытия программы - нажмите Escape): ");
            }
        }
    }

    static void IsKeyPressed()
    {
        while (true)
        {
            if (Console.KeyAvailable)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    case ConsoleKey.Q:
                        Console.Clear();
                        Console.WriteLine("Консоль очищена. Введите новый конец диапазона или нажмите Escape для выхода:");
                        break;
                }
            }
            Thread.Sleep(100); // небольшая задержка для снижения нагрузки
        }
    }
}