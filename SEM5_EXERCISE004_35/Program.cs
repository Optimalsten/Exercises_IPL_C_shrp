// Задача 35: Задайте одномерный массив из 5 случайных чисел на диапазоне [0, 123].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5.
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int GetCount(int[] arr, int minN, int maxN)
{
    int countN = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= minN && arr[i] <= maxN)
        {
            countN++;
        }
    }
    return countN;
}

int GetNumber(string message)
{
    Console.Write($"Введите целое число {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] arr = GetArray(5, 0, 123);
Print(arr);
int number1 = GetNumber(" - нижняя граница");
int number2 = GetNumber(" - верхняя граница");

Console.WriteLine($"\nКоличество элементов массива в диапазоне" 
+ $"\n[{number1}, {number2}] равно {GetCount(arr, number1, number2)}.\n");


