// Напишите программу, которая на вход принимает число и выдает его квадрат
// (число, умноженное на само себя)
// Например:
// 4    ->  16
// -3   ->  9
// -7   ->  49

Console.Write("Enter number : ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

int sqr = num * num;

Console.WriteLine(sqr);
 