// Задача 10:
// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine();
int num = int.Parse(number);

if (num < 100 || num > 999)
{
    Console.Write($"Введенное число некорректно {num}");
}
else
{
    // int num1 = num % 10;
    // num = num - num1;
    int num2 = (num % 100) / 10;
    Console.Write($"Вторая цифра числа {num2}");
}
// См. домашнюю работу - SEM2_HOMEW001 - там улучшения.
