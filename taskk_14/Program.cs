class Program
{
    static void Main()
    {
        string[] array = { "gre","23", "ht","4f", "g34"};
        Console.Write("Введите то, что хотите найти в массиве: ");

        string value = Console.ReadLine();

        bool isContain = false;
        for(int i  = 0; i < array.Length; i++)
        {
            if(array[i] == value)
            {
                isContain = true;
                Console.Write(i);
            }
        }
        if (!isContain)
        {
            Console.WriteLine("Такого элемента нет в массиве!");
        }
    }
}