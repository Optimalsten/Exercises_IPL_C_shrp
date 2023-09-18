// Задача 42: Напишите программу,
// которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int take(string message)
{
    Console.WriteLine("Enter number");
    int number = Console.ToInt32(Console.ReadLine());
    return number;
}

int[] Convertation(int number)
{
    int[] array = new int[32];
    for (int i = 0; number > 0; i++)
    {
        array[array.Length - 1 - i] = number % 2;
        number /= 2;
    }
    return array;
}

Console.WriteLine();
int number = take();

string print = string.Join(", ", Convertation(number));
Console.WriteLine(print);



string DecToNum(int decNumber = 1070, int otherSystem = 2)
{
    string res = "";
    string nums = "0123456789ABCDEF";
    while (decNumber > 0)
    {
        //int ost=decNumber/otherSystem;
        res = nums[decNumber % otherSystem] + res;// res = "0" + "" ="0"  // res = "1"+ "0"
        decNumber /= otherSystem;//d=535
    }
    return res;
}


