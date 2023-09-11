// Задача 28: Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int GetNumber(string message)
    {
        Console.Write($"Введите целое число {message}: ");
        int num = Convert.ToInt32(Console.ReadLine());
        return num;
    }

long Composit(int num)
{
    long comp = 1;
    for (int i = 2; i <= num; i++)
    {
        comp = comp * i;
    }
    return comp;
}

int num = GetNumber("");
Console.WriteLine($"\nФакториал числа {num} равен {Composit(num)}.");

// Задержка экрана
Console.Write("\nДля продолжения нажмите любую клавишу..."); //  "\n - "возврат каретки"
Console.Read();