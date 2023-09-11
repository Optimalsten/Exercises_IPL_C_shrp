// Задача 24: Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Sum1A(int nA)
{
    int sumNum1A = 0;
    for (int i = 1; i <= nA; i++)
    {
        sumNum1A = sumNum1A + i;
    }
    return sumNum1A;
}

int SumFr1ToA(int nA)
{
    int temp = nA / 2;
    int sFr1ToA = (nA + 1) * temp;

    if (2 * temp < nA)
    {
        sFr1ToA = sFr1ToA + (temp +1);
    }
    return sFr1ToA;
}

Console.WriteLine("\nЗадайте целое положительное число (A) " +
"\n- для последующего вывода на печать суммы чисел от 1 до A.");
Console.Write("\nВведите число: ");

string numberA = Console.ReadLine();
int numA = int.Parse(numberA);

if (numA < 1)
{
    Console.WriteLine($"\nЗаданное Вами число {numA} - некорректно");
}
else
{
    //Первый способ
    int summa1A = Sum1A(numA);
    Console.WriteLine($"Сумма чисел от 1 до {numA} равна {Sum1A(numA)}.");

    // Второй способ
    summa1A = SumFr1ToA(numA);
    Console.WriteLine($"Сумма чисел от 1 до {numA} равна {SumFr1ToA(numA)}.");
}

// Задержка экрана
Console.Write("\nДля продолжения нажмите любую клавишу..."); //  "\n - "возврат каретки"
Console.Read();


int num = 10;
int num2 = num++; // сначала отдал 10 в num2 а потом себя увеличил на 1

Console.WriteLine(num, num2);

int num3 = ++num; // сначала прибавит 1 в себя, а потом присвоит полученное в num3

Console.WriteLine(num, num3);
