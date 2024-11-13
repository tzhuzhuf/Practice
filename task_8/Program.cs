using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Выберите прощадь какой фигуры хотите вычислить\n1 - круг\n2 - треугольник\n3 - прямоугольник\nДля выхода нажмите Escape...");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    double radius;
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Введите радиус круга: ");

                        if (double.TryParse(Console.ReadLine(), out radius))
                        {
                            Console.WriteLine($"Площадь круга равна: {3.1415926535 *  Math.Pow(radius, 2) }");
                            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить, либо Escape, чтобы закрыть программу: ");
                            switch (Console.ReadKey(true).Key)
                            {
                                case ConsoleKey.Escape:
                                    Environment.Exit(0);
                                    break;
                                default:
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
                        break;
                    }
                    break;
                case ConsoleKey.D2:
                    double h;
                    double a;
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Введите высоту треугольника: ");
                        if (double.TryParse(Console.ReadLine(), out h))
                        {
                            Console.Write("Введите длину стороны, к которой проведена высота: ");
                            if (double.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine($"Площадь треугольника равна: {a * h / 2}");
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
                    break;
                case ConsoleKey.D3:
                    double a2;
                    double b;
                    while (true)
                    {
                        Console.Write("Введите длину прямоугольника: ");
                        if (double.TryParse(Console.ReadLine(), out a2))
                        {
                            Console.Write("Введите ширину прямоугольника: ");
                            if (double.TryParse(Console.ReadLine(), out b))
                            {
                                Console.WriteLine($"Площадь прямоугольника равна: {a2 * b}");
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
                        break;

                    }
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                default:
                    continue;
            }
        }
    }
}
