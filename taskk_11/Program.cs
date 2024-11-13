using System;

namespace Converter
{
    class Program
    {
        static void Main()
        {

            const double dollarToRubleExchangeRate = 98.2;
            const double euroToRubleExchangeRate = 104.3;

            Console.Write($"Курс доллара = {dollarToRubleExchangeRate} руб.\nКурс евро = {euroToRubleExchangeRate} руб.");

            Console.Write("Введите сумму рублей: ");
            double amountOfRuble = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите в какую валюту конвертировать рубли (1 - доллар, 2 - евро):");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine( amountOfRuble / dollarToRubleExchangeRate );
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine(amountOfRuble / euroToRubleExchangeRate );
                    break;
            }
        }
    }
}