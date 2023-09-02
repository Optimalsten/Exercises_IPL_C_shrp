// Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.
// a = 25,  b = 5     ->  да
// a = 2,   b = 10    ->  нет
// a = 9,   b = -3    ->  да
// a = -3,  b = 9     ->  нет

Console.Write("Enter number : ");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.Write("Enter number : ");
strNum = Console.ReadLine();
int num2 = int.Parse(strNum);

int sqr = num2 * num2;

if (sqr == num1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
