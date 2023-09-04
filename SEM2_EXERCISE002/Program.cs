// Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);
Console.WriteLine(num);

int num1 = num / 100;
int num3 = num % 10;

int rez = num1 * 10 + num3;

System.Console.WriteLine(rez);
