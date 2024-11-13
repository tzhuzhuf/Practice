using System;
using System.Collections;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("enter something:");
            string input = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input is empty.\n");
                continue;
            }

            string[] words = input.Split([' ', '\t', '\n'], StringSplitOptions.RemoveEmptyEntries);
            int inputLength = words.Length;

            int sentensesCount = Regex.Matches(input, @"[.!?]").Count;

            Console.WriteLine($"Text length: {input.Length}\nNumber of words: {inputLength}\nNumber of sentences: {sentensesCount}");

            Console.WriteLine("\nDo you want to continue? Y/N");
            while (true)
            {
                string choice = Console.ReadLine().ToUpper();
                switch (choice)
                {
                    case "Y":
                        Console.Clear();
                        break;
                    case "N":
                        return;
                    default:
                        continue;
                }
                break;
            }
        }
    }
}