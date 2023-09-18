// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// МЕТОД ЗАДАНИЯ с клав-ы ЦЕЛОГО ЧИСЛА, с контролем допустимости типа значения
// int GetNumberContr(string message, out bool contrNum) // conrtNum - True (корректно)/False (некорректно)
// {
//     Console.Write($"\n Задайте число {message}");

//     string numberStr = Console.ReadLine();
//     contrNum = int.TryParse(numberStr, out int numN); // numN = 0 (если некорректно)
//     return numN;
// }


// МЕТОД ЗАДАНИЯ с клав-ы ЦЕЛОГО ЧИСЛА, без контроля допустимости типа введенного значения
int GetNumber(string message)
{
    Console.Write($"Введите целое число {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int number = GetNumber("для вывода первых N чисел Фибоначчи. N = ");

if (number < 0) Console.WriteLine($"\n Заданное значение N = {number} некорректно");

int num1 = 0;
if (number >= 0)
{
        Console.WriteLine(num1);
}
int num2 = 1;
if (number >= 1)
{
        Console.WriteLine(num2);
} 

if (number >= 2)
{
    int next = 0;
    for (int i = 2; i < number; i++)
    {
        next = num1 + num2;
        Console.WriteLine(next);
        num1 = num2;
        num2 = next;
    }
}

// Задержка экрана
Console.Write("\nДля продолжения нажмите любую клавишу...\n"); //  "\n - "возврат каретки"
Console.Read();