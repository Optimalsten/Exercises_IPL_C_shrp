// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса нечётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив     Новый массив будет выглядеть
// выглядел вот так:               вот так:  
// 1 4 7 2                         1 4 7 2
// 5 9 2 3                         5 81 2 9
// 8 4 2 4                         8 4 2 4

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

void GetMatrixSqr(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0)) matrix[i, j] *= matrix[i, j];
        }
    }
}


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

int rows = SetNumber("- количество строк");
int columns = SetNumber("- количество столбцов");


int[,] result = GetMatrix(rows, columns);
PrintMatrix(result);
Console.WriteLine();
GetMatrixSqr(result);
PrintMatrix(result);
