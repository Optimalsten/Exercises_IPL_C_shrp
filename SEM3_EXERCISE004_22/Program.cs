// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт
// таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

Console.WriteLine("\nЗадайте целое положительное число (N)" +
"\nдля определения квадратов чисел от 1 до N.\n");
Console.Write($"Введите число N : ");

string numbStr = Console.ReadLine();
int num = int.Parse(numbStr);

if (num < 1)
{
    Console.Write($"\nЗаданное Вами число ({num}) - некорректно.");
}
else
{
    Console.Write($"\nЧисло       Квадрат числа\n");
    int numN = 1;
    while (numN <= num)
    {
        Console.Write($"\n  {numN}           {numN * numN}");
        numN++;
    }
}
// Задержка экрана
Console.WriteLine("\n\nДля продолжения нажмите любую клавишу..."); //  "\n - "возврат каретки"
Console.Read();

