using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.Write("Введите конец диапазона для простых чисел, которые нужно вывести: ");
        int endOfRange;
        bool isSimple;

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out endOfRange))
            {
                Console.Write($"\nВсе простые числа от 1 до {endOfRange}: ");
                for (int i = 2; i <= endOfRange; i++)
                {
                    isSimple = true;
                    for (int j = 2; j < i; j++) 
                    {
                        if (i % j == 0) // проверяю, делится ли число на какое-либо из чисел, которые меньше его. Если делится, то число непростое.
                        {
                            isSimple = false;
                            break;
                        }
                    }
                    if (isSimple)
                        Console.Write(i + " ");
                }
                Console.Write("\nНажмите любую клавишу, чтобы продолжить, либо Escape, чтобы закрыть программу: ");
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
                Console.Clear();
                Console.Write("Некорректный ввод! Попробуйте ещё раз: ");
            }
        }
    }
}
