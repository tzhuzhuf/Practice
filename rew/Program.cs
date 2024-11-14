using System;

class Program
{
    static void Main()
    {
        int rows = 4; // Количество строк (уровней)
        int[][] triangle = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            triangle[i] = new int[i + 1];
            triangle[i][0] = 1;
            triangle[i][i] = 1;

            for (int j = 1; j < i; j++)
            {
                triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
            }
        }

        // Вывод треугольника Паскаля
        for (int i = 0; i < rows; i++)
        {
            Console.Write(new string(' ', (rows - i) * 2));
            for (int j = 0; j <= i; j++)
            {
                Console.Write($"{triangle[i][j]} ");
            }
            Console.WriteLine();
        }
    }
}
