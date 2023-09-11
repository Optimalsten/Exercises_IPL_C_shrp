// Задача 26: Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int GetNumber(string message)
    {
        Console.Write($"Введите целое число {message}: ");
        int num = Convert.ToInt32(Console.ReadLine());
        return num;
    }

int Getcount(int num)
{
    int count = 0;
    // while (num > 0)
    // {
    //     num = num / 10;
    //     count++;
    // }
    for (; 0 < num; num /= 10)
    {
        count++;
    }
        return count;
}
int num = GetNumber("A");
Console.WriteLine($"\nКоличество цифр в числе {Getcount(num)}.");

// Задержка экрана
Console.Write("\nДля продолжения нажмите любую клавишу..."); //  "\n - "возврат каретки"
Console.Read();