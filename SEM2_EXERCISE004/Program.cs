// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Write("Введите число: ");
string number1 = Console.ReadLine();
int num1 = int.Parse(number1);

if (num1 % 7 == 0 && num1 % 23 == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("некратно");
}
