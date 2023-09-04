// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Write("Введите первое число: ");
string number01 = Console.ReadLine();
int num01 = int.Parse(number01);

Console.Write("Введите второе число: ");
string number02 = Console.ReadLine();
int num02 = int.Parse(number02);

if (num01 * num01 == num02 || num02 * num02 == num01)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}