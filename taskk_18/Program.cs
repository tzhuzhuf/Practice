class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество уровней: ");
        int numberOfLevels = int.Parse(Console.ReadLine());
        for(int i = 1; i < numberOfLevels + 1; i++)
        {
            for(int j = 0;  j < i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for(int i = 0, k = 1;i < numberOfLevels; i++)
        {
            for (int j = 0; j <= i; j++, k++)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        // 3 пирамида
        int[,] ints = new int[numberOfLevels,numberOfLevels];
        for(int i = 0; i < numberOfLevels; i++)
        {
            for(int j = 0; j <= i; j++)
            {
                if (j == 0 || j == ints.GetLength(1) - 1)
                {
                    ints[i, j] = 1;
                    Console.Write(ints[i, j] + " ");
                    continue;
                }
                    
                ints[i,j] = ints[i - 1, j - 1] + ints[i -1 , j];
                Console.Write(ints[i,j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        for (int i = 0, k = numberOfLevels; i < numberOfLevels; i++, k--)
        {
            for (int j = 0; j < k; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <= i; j++)
            {
                Console.Write(ints[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}