using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите операцию (1 - сложение, 2 - вычитание, 3 - умножение, 4 - транспонирование): ");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Первая матрица");
                    Matrix matrix1 = Matrix.CreateMatrix();
                    Console.WriteLine("Вторая матрицы");
                    Matrix matrix2 = Matrix.CreateMatrix();
                    Matrix result = matrix1.Add(matrix2);
                    result.Print();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("Первая матрица");
                    Matrix matrixx1 = Matrix.CreateMatrix();
                    Console.WriteLine("Вторая матрицы");
                    Matrix matrixx2 = Matrix.CreateMatrix();
                    Matrix result1 = matrixx1.Subtract(matrixx2);
                    result1.Print();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("Первая матрица");
                    Matrix matrixxx1 = Matrix.CreateMatrix();
                    Console.WriteLine("Вторая матрицы");
                    Matrix matrixxx2 = Matrix.CreateMatrix();
                    Matrix result2 = matrixxx1.Multiply(matrixxx2);
                    result2.Print();
                    break;
                case ConsoleKey.D4:
                    Matrix matrix = Matrix.CreateMatrix();
                    Matrix result3 = matrix.Transpose();
                    result3.Print();
                    break;
                default:
                    continue;
            }
        }
    }
}
class Matrix
{
    private int[,] matrix;
    public int this[int line, int column]
    {
        get { return matrix[line, column]; }
        set { matrix[line, column] = value; }
    }

    public Matrix(int lines, int columns)
    {
        matrix = new int[lines, columns];
    }

    public static Matrix CreateMatrix()
    {
        Console.WriteLine("Введите количество строк матрицы: ");
        int lines = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов матрицы: ");
        int columns = int.Parse(Console.ReadLine());

        Matrix matrix = new Matrix(lines, columns);
        matrix.Fill(lines, columns);
        return matrix;
    }
    public int[,] Fill(int lines, int columns)
    {
        Console.WriteLine("Вводите последовательно элементы матрицы: ");
        for (int i = 0; i < lines; ++i)
        {
            for (int j = 0; j < columns; ++j)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        return matrix;
    }

    public Matrix Add(Matrix other)
    {
        if (this.matrix.GetLength(0) != other.matrix.GetLength(0) || this.matrix.GetLength(1) != other.matrix.GetLength(1))
        {
            throw new InvalidOperationException("Для выполнения сложения матрицы должны быть однинакового размера!");
        }
        Matrix result = new Matrix(this.matrix.GetLength(0), this.matrix.GetLength(1));
        for (int i = 0; i < this.matrix.GetLength(0); i++)
        {
            for (int j = 0; j < this.matrix.GetLength(1); j++)
            {
                result[i, j] = this[i, j] + other[i, j];
            }
        }
        return result;
    }
    public Matrix Subtract(Matrix other)
    {
        if (this.matrix.GetLength(0) != other.matrix.GetLength(0) || this.matrix.GetLength(1) != other.matrix.GetLength(1))
        {
            throw new InvalidOperationException("Для выполнения вычитания матрицы должны быть однинакового размера!");
        }
        Matrix result = new Matrix(this.matrix.GetLength(0), this.matrix.GetLength(1));
        for(int i = 0; i < this.matrix.GetLength(0); i++)
        {
            for(int j = 0; j < this.matrix.GetLength(1); j++)
            {
                result[i,j] = this[i, j] - other[i, j];
            }
        }
        return result;
    }
    public Matrix Multiply(Matrix other)
    {
        if (this.matrix.GetLength(1) != other.matrix.GetLength(0))
        {
            throw new InvalidOperationException("Число столбцов первой матрицы должно быть равно числу строк второй матрицы!");
        }

        Matrix result = new Matrix(this.matrix.GetLength(0), other.matrix.GetLength(1));
        for (int i = 0; i < this.matrix.GetLength(0); i++)
        {
            for(int j = 0;j < other.matrix.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < this.matrix.GetLength(1); k++)
                {
                    sum += this[i, k] * other[k, j];
                }
                result[i,j] = sum;
            }
        }
        return result;

    }
    public Matrix Transpose()
    {
        Matrix result = new Matrix(matrix.GetLength(1), matrix.GetLength(0));
        for(int i = 0;  i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                result[j,i] = matrix[i,j];
            }
        }
        return result;
    }
    public void Print()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}