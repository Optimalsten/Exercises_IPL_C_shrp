// Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные,
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

void Change (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

int[] array = GetArray(12, -9, 9);
Print(array); 
Change(array);
Print(array); 
