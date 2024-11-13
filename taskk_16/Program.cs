class Program
{
    static void Main()
    {
        Console.WriteLine("Введите размер матриц");
        Console.Write("Количество строк: ");
        int lines = int.Parse(Console.ReadLine());

        Console.Write("Количество столбцов: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix1 = new int[lines, columns];
        int[,] matrix2 = new int[lines, columns];

        Console.WriteLine("Введите первую матрицу: ");
        for(int i = 0; i < lines; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Введите вторую матрицу: ");
        for (int i = 0; i < lines; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Выберите операцию (1 - сложение, 2 - вычитание, 3 - умножение, 4 - транспонирование): ");
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.D1:



        }
    }
}
class MatrixCalculator
{
    static int[,] Add()
    {

    }
}