// Задача № 5. Напишите программу, которая будет на вход принимает одно целое число (N),
// а на выходе показывает все целые числа в промежутке от (- N) до N.
// 4   -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2   -> "-2, -1, 0, 1, 2"

Console.Write("Введите целое положительное число: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

int num0 = num * -1;

while (num0 <= num)
{
    Console.WriteLine (num0);
    num0 ++;
}
