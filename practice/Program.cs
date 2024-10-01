using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение, которое хотите перевести в другую единицу измерения: ");

        double value;
        if (double.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Введите единицу измерения (кг - килограммы, г - граммы, км - киллометры, м - метры): ");

            string UnitsOfMeasurement = Console.ReadLine();
            switch (UnitsOfMeasurement)
            {
                case "кг":
                    Console.WriteLine("Во что переводить? (1 - граммы, 2 - миллиграммы, 3 - микрограммы)");

                    ConsoleKey choice = Console.ReadKey(true).Key;

                    switch (choice)
                    {
                        case ConsoleKey.D1:
                            Console.WriteLine(value *= 1000);
                            break;
                        case ConsoleKey.D2:
                            Console.WriteLine(value *= 1000000);
                            break;
                        case ConsoleKey.D3:
                            Console.WriteLine(value *= 1000000000);
                            break;
                        default:
                            Console.WriteLine("Некорректный ввод!\nХотите продолжить? (Y/N)");

                            while (true)
                            {
                                ConsoleKey choice2 = Console.ReadKey(true).Key;
                                switch (choice2)
                                {
                                    case ConsoleKey.Y:
                                        break;
                                    case ConsoleKey.N:
                                        return;
                                    default:
                                        Console.WriteLine("Некорректный ввод");
                                        continue;
                                }
                                continue;
                            }
                    }
                    break;

                case "г":
                    Console.WriteLine("Во что переводить? (1 - киллограммы, 2 - миллиграммы, 3 - микрограммы)");

                    ConsoleKey Key = Console.ReadKey(true).Key;

                    switch (Key)
                    {
                        case ConsoleKey.D1:
                            Console.WriteLine(value /= 1000);
                            break;
                        case ConsoleKey.D2:
                            Console.WriteLine(value *= 1000);
                            break;
                        case ConsoleKey.D3:
                            Console.WriteLine(value *= 1000000);
                            break;
                        default:
                            Console.WriteLine("Некорректный ввод!\nХотите продолжить? (Y/N)");

                            while (true)
                            {
                                ConsoleKey choice2 = Console.ReadKey(true).Key;
                                switch (choice2)
                                {
                                    case ConsoleKey.Y:
                                        break;
                                    case ConsoleKey.N:
                                        return;
                                    default:
                                        Console.WriteLine("Некорректный ввод");
                                        continue;
                                }
                                continue;
                            }
                    }
                    break;

                case "км":
                    Console.WriteLine("Во что переводить? (1 - метры, 2 - миллиметры, 3 - микрометры)");

                    ConsoleKey key = Console.ReadKey(true).Key;

                    switch (key)
                    {
                        case ConsoleKey.D1:
                            Console.WriteLine(value *= 1000);
                            break;
                        case ConsoleKey.D2:
                            Console.WriteLine(value *= 1000000);
                            break;
                        case ConsoleKey.D3:
                            Console.WriteLine(value *= 1000000000);
                            break;
                        default:
                            Console.WriteLine("Некорректный ввод!\nХотите продолжить? (Y/N)");

                            while (true)
                            {
                                ConsoleKey choice2 = Console.ReadKey(true).Key;
                                switch (choice2)
                                {
                                    case ConsoleKey.Y:
                                        break;
                                    case ConsoleKey.N:
                                        return;
                                    default:
                                        Console.WriteLine("Некорректный ввод");
                                        continue;
                                }
                                continue;
                            }
                    }
                    break;
                case "м":
                    Console.WriteLine("Во что переводить? (1 - киллограммы, 2 - миллиграммы, 3 - микрограммы)");

                    ConsoleKey keykey = Console.ReadKey(true).Key;

                    switch (keykey)
                    {
                        case ConsoleKey.D1:
                            Console.WriteLine(value /= 1000);
                            break;
                        case ConsoleKey.D2:
                            Console.WriteLine(value *= 1000);
                            break;
                        case ConsoleKey.D3:
                            Console.WriteLine(value *= 1000000);
                            break;
                        default:
                            Console.WriteLine("Некорректный ввод!\nХотите продолжить? (Y/N)");

                            while (true)
                            {
                                ConsoleKey choice2 = Console.ReadKey(true).Key;
                                switch (choice2)
                                {
                                    case ConsoleKey.Y:
                                        break;
                                    case ConsoleKey.N:
                                        return;
                                    default:
                                        Console.WriteLine("Некорректный ввод");
                                        continue;
                                }
                                continue;
                            }
                    }
                    break;
            }
        }
        else
        {

        }
    }
}