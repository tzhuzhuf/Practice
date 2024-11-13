class Program
{
    static void Main()
    {
        int[] ints = { 23, 3, 423423, 4, 2342 };
        int maxValue = ints[0];
        int minValue = ints[0];
        int maxValueIndex = 0;
        int minValueIndex = 0;

        for (int i = 0; i < ints.Length - 1; i++)
        {
            if (ints[i] == ints[i + 1]) continue;

            if (maxValue < ints[i + 1])
            {
                maxValue = ints[i + 1];
                maxValueIndex = i + 1;
            }
            else if (minValue < ints[i + 1])
            {
                minValue = ints[i + 1];
                minValueIndex = i + 1;
            }
        }
        Console.WriteLine($"Максимальный элемент: {maxValue}, его индекс: {maxValueIndex}\nМинимальный элемент: {minValue}, его индекс: {minValueIndex}");
    }
}