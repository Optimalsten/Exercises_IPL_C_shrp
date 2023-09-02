// Задача № 7. Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает последнюю цифру этого числа.
// 456     ->  6
// 782     ->  2
// 918     ->  8

// string strNum = Console.ReadLine();

Console.Write("Введите целое трехзначное число: ");
int num = int.Parse(Console.ReadLine());
if(num>99 && num<1000)
{
    Console.WriteLine(num % 10);
}
else
{
    Console.WriteLine("Вы ввели некорректные данные");
}