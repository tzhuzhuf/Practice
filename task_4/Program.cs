using System;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("enter an integer number (>0):");

            uint number;
            ulong factorial = 1;

            if (uint.TryParse(Console.ReadLine().Trim(), out number))
            {
                for (int i = 1; number > i; number--)
                {
                    factorial *= number;
                }
                Console.WriteLine($"Factorial = {factorial}");
            }
            else
            {
                Console.WriteLine("\nincorrect input");
            }
            while (true)
            {
                Console.WriteLine("Do you want to continue? Y/N");
                string choice = Console.ReadLine().ToUpper();
                switch (choice)
                {
                    case "Y":
                        Console.Clear();
                        break;
                    case "N":
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("incorrect input");
                        continue;
                }
                break;
            }
        }
    }
}