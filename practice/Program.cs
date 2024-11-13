using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите значение, которое хотите перевести в другую единицу измерения: ");

            double value;
            if (double.TryParse(Console.ReadLine(), out value))
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"Ваш ввод: {value}");
                    Console.WriteLine("Введите единицу измерения (1 - килограммы, 2 - граммы, 3 - киллометры, 4 - метры):\nНажмите Escape, чтобы закрыть программу...");
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.D1:
                            Console.WriteLine("Во что переводить? (1 - граммы, 2 - миллиграммы, 3 - микрограммы)\nНажмите Escape, чтобы закрыть программу...");

                            switch (Console.ReadKey(true).Key)
                            {
                                case ConsoleKey.D1:
                                    Console.WriteLine($"{value} кг =  {value *= 1000} гр.");
                                    break;
                                case ConsoleKey.D2:
                                    Console.WriteLine($"{value} кг =  {value *= 1000000} миллигр.");
                                    break;
                                case ConsoleKey.D3:
                                    Console.WriteLine($"{value} кг =  {value *= 1000000000} микрогр.");
                                    break;
                                case ConsoleKey.Escape:
                                    Environment.Exit(0);
                                    break;
                                default:
                                    continue;
                            }
                            break;

                        case ConsoleKey.D2:
                            Console.WriteLine("Во что переводить? (1 - киллограммы, 2 - миллиграммы, 3 - микрограммы)\nНажмите Escape, чтобы закрыть программу...");

                            switch (Console.ReadKey(true).Key)
                            {
                                case ConsoleKey.D1:
                                    Console.WriteLine($"{value} гр =  {value /= 1000} кг.");
                                    break;
                                case ConsoleKey.D2:
                                    Console.WriteLine($"{value} гр =  {value *= 1000} млг.");
                                    break;
                                case ConsoleKey.D3:
                                    Console.WriteLine($"{value} гр =  {value *= 1000000} мкг.");
                                    break;
                                case ConsoleKey.Escape:
                                    Environment.Exit(0);
                                    break;
                                default:
                                    continue;
                            }
                            break;

                        case ConsoleKey.D3:
                            Console.WriteLine("Во что переводить? (1 - метры, 2 - миллиметры, 3 - микрометры)\nНажмите Escape, чтобы закрыть программу...");

                            switch (Console.ReadKey(true).Key)
                            {
                                case ConsoleKey.D1:
                                    Console.WriteLine($"{value} км =  {value *= 1000} м.");
                                    break;
                                case ConsoleKey.D2:
                                    Console.WriteLine($"{value} км =  {value *= 1000000} млм.");
                                    break;
                                case ConsoleKey.D3:
                                    Console.WriteLine($"{value} км =  {value *= 1000000000} мкм.");
                                    break;
                                case ConsoleKey.Escape:
                                    Environment.Exit(0);
                                    break;
                                default:
                                    continue;
                            }
                            break;
                        case ConsoleKey.D4:
                            Console.WriteLine("Во что переводить? (1 - киллометры, 2 - миллиметры, 3 - микрометры)\nНажмите Escape, чтобы закрыть программу...");

                            switch (Console.ReadKey(true).Key)
                            {
                                case ConsoleKey.D1:
                                    Console.WriteLine($"{value} м = {value /= 1000} км.");
                                    break;
                                case ConsoleKey.D2:
                                    Console.WriteLine($"{value} м = {value *= 1000} млм.");
                                    break;
                                case ConsoleKey.D3:
                                    Console.WriteLine($"{value} м = {value *= 1000000} мкм.");
                                    break;
                                case ConsoleKey.Escape:
                                    Environment.Exit(0);
                                    break;
                                default:
                                    continue;
                            }
                            break;
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                        default:
                            continue;
                    }
                    Console.WriteLine("Нажмите любую клавишу, чтобы продолжить, либо Escape, чтобы закрыть программу: ");
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                    break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод!\nНажмите любую клавишу, чтобы продолжить, либо Escape, чтобы закрыть программу: ");
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