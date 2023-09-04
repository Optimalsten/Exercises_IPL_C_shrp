// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int num = new Random().Next(10, 100);
Console.WriteLine(num);

int num1 = num / 10;
int num2 = num % 10;

if(num1 > num2)
{
    Console.WriteLine($" max = {num1}");
}
else
{
    Console.WriteLine(" max = " + num2);
}