class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число в десятеричной системе счисления:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Двоичное представление:" + Translator.ToBinary(num));
        Console.WriteLine("Восьмеричное:" + Translator.ToOctal(num));
        Console.WriteLine("Шестнадцатеричное:" + Translator.ToHex(num));
    }
}
class Translator
{   
    public static string ToBinary(int num)
    {
        string binary = "";
        while(num > 0)
        {
            binary = num % 2 + binary; 
            num /= 2;
        }
        return binary;
    }

    public static string ToOctal(int num)
    {
        string octal = "";
        while (num > 0)
        {
            octal = num % 8 + octal;
            num /= 8;
        }
        return octal;
    }
    public static string ToHex(int num)
    {
        string hex = "";
        while (num > 0)
        {
            int remainder = num % 16;
            if (remainder < 10)
            {
                hex = remainder + hex;
            }
            else
            {
                hex = (char)('A' + (remainder - 10)) + hex;
            }
            num /= 16;
        }
        return hex;
    }
}