Console.Write("Введите первую дату в формате year.month.day: ");
string input1 = Console.ReadLine().Trim();
int[] array1 = input1.Split('.').Select(x => int.Parse(x)).ToArray();
DateTime date1 = new DateTime(array1[0], array1[1], array1[2]);

Console.Write("Введите вторую дату в том же формате: ");
string input2 = Console.ReadLine().Trim();
int[] array2 = input2.Split('.').Select(x => int.Parse(x)).ToArray();
DateTime date2 = new DateTime(array2[0], array2[1], array2[2]);

Console.WriteLine(date1.Subtract(date2));


