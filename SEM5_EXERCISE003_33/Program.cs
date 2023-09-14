// Задача 33: Задайте массив. Напишите программу,
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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

int GetNumber(string message)
{
    Console.Write($"Введите целое число {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int GetIndexSearch(int[] arr, int number)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number || arr[i] == -number)
        {
            return i;        
        }
    }
    return -1;
}

int[] array = GetArray(8, -9, 9);
Print(array);
int number = GetNumber("");
int numIndex = GetIndexSearch(array, number);
if (numIndex == -1)
{
    Console.WriteLine($"\nТакое число {number} не найдено.");
}
else
{
    Console.WriteLine($"\nИндекс числа {number} равен {numIndex}.");
}


