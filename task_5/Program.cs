using System;
using System.Threading;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Введите количество чисел Фиблоначчи, которые нужно вывести: ");
            try
            {
                int quantity = int.Parse(Console.ReadLine());
                if (quantity < 1)
                {
                    Console.WriteLine("\nНеверный формат ввода!\nНажмите любую клавишу, чтобы продолжить, либо Escape, чтобы закрыть программу: ");
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                        default:
                            continue;
                    }
                }
                if (quantity == 1)
                {
                    Console.WriteLine("\nНеверный формат ввода!\nНажмите любую клавишу, чтобы продолжить, либо Escape, чтобы закрыть программу: ");
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                        default:
                            continue;
                    }
                }
                ulong num1 = 0; ulong num2 = 1;
                Console.Write($"{num1} {num2} ");
                ulong temp;
                for (int i = 0; i < quantity - 2; i++)
                {
                    temp = num1 + num2;
                    num1 = num2;
                    num2 = temp; 
                    Console.Write(temp + " ");
                }
                Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить, либо Escape, чтобы закрыть программу: ");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    default:
                        continue;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка ввода: " + ex.Message);
                Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить, либо Escape, чтобы закрыть программу: ");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}