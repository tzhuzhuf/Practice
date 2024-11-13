class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Игра \"Угадай число\"");
            Console.WriteLine("Вам нужно угадать число от 1 до 100.");
            Console.Write("Ввод: ");

            int input;
            if (int.TryParse(Console.ReadLine(), out input))
            {
                int number = GenerateIntegerNumber();
                if(input == number)
                {
                    Console.WriteLine("Ты победил!");
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
                    Console.WriteLine($"К сожалению ты проиграл.\nЗагаданное число: {number}");
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

    static int GenerateIntegerNumber()
    {
        Random random = new Random();
        int number = random.Next(100);
        return number;
    }
}
