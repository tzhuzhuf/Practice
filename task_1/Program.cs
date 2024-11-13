using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("enter the first number:");

            float firstNum;
            float secondNum;

            if (float.TryParse(Console.ReadLine(), out firstNum))
            {
                Console.WriteLine("enter the second number:");
                if (float.TryParse(Console.ReadLine(), out secondNum))
                {
                    Console.WriteLine("enter the arithmetic operation (use +, -, *, /)");
                    string operation = Console.ReadLine();
                    switch (operation)
                    {
                        case "+":
                            Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
                            break;
                        case "-":
                            Console.WriteLine($"{firstNum} - {secondNum} = {firstNum - secondNum}");
                            break;
                        case "*":
                            Console.WriteLine($"{firstNum} * {secondNum} = {firstNum * secondNum}");
                            break;
                        case "/":
                            Console.WriteLine($"{firstNum} / {secondNum} = {firstNum / secondNum}");
                            break;
                        default:
                            Console.WriteLine("incorrect input");
                            break;
                    }
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
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("incorrect input");
                }
            }
            else
            {
                Console.WriteLine("incorrect input");
            }
        }
    }
}