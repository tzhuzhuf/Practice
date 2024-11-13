using System;
using System.Threading;

namespace task_3
{
    public class MultiplicationTable
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("enter the number (1 - 10):");

                int number;

                if (int.TryParse(Console.ReadLine().Trim(), out number))
                {
                    switch (number)
                    {
                        case 1:
                            for (int i = 1; i < 11; i++)
                            {
                                Console.WriteLine($"{number} * {i} = {number * i}");
                            }
                            break;
                        case 2:
                            for (int i = 1; i < 11; i++)
                            {
                                Console.WriteLine($"{number} * {i} = {number * i}");
                            }
                            break;
                        case 3:
                            for (int i = 1; i < 11; i++)
                            {
                                Console.WriteLine($"{number} * {i} = {number * i}");
                            }
                            break;
                        case 4:
                            for (int i = 1; i < 11; i++)
                            {
                                Console.WriteLine($"{number} * {i} = {number * i}");
                            }
                            break;
                        case 5:
                            for (int i = 1; i < 11; i++)
                            {
                                Console.WriteLine($"{number} * {i} = {number * i}");
                            }
                            break;
                        case 6:
                            for (int i = 1; i < 11; i++)
                            {
                                Console.WriteLine($"{number} * {i} = {number * i}");
                            }
                            break;
                        case 7:
                            for (int i = 1; i < 11; i++)
                            {
                                Console.WriteLine($"{number} * {i} = {number * i}");
                            }
                            break;
                        case 8:
                            for (int i = 1; i < 11; i++)
                            {
                                Console.WriteLine($"{number} * {i} = {number * i}");
                            }
                            break;
                        case 9:
                            for (int i = 1; i < 11; i++)
                            {
                                Console.WriteLine($"{number} * {i} = {number * i}");
                            }
                            break;
                        case 10:
                            for (int i = 1; i < 11; i++)
                            {
                                Console.WriteLine($"{number} * {i} = {number * i}");
                            }
                            break;
                        default:
                            Console.WriteLine("incorrect input");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("incorrect input");
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
                            Console.WriteLine("incorrect input");
                            Thread.Sleep(1000);
                            Console.Clear();
                            continue;
                    }
                    break;
                }
            }
        }
    }
}
