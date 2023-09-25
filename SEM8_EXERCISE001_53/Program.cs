// Задача 53: Задайте двумерный массив.
// Напишите программу, которая поменяет местами
// первую и последнюю строку массива.

int SetNumber(string message)
{
    Console.Write($"Введите число {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write($"{matrix[i, l]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetMatrix(int rows, int columns, int min = 0, int max = 99)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}

void Change(int[,] matrix)
{
    int temp;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }
}

int rows = SetNumber("- количество строк");
int columns = SetNumber("- количество столбцов");

int[,] result = GetMatrix(rows, columns);
PrintMatrix(result);
Console.WriteLine();
Change(result);
PrintMatrix(result);
Console.WriteLine();



