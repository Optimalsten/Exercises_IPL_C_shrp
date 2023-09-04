// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
string number01 = Console.ReadLine();
int num01 = int.Parse(number01);

Console.Write("Введите второе число: ");
string number02 = Console.ReadLine();
int num02 = int.Parse(number02);

int num03 = num01 % num02;

if (num03 == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine($"не кратно, остаток {num03}");
}
