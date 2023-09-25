// Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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
            Console.Write($"{matrix[i, l]} \t");
        }
        Console.WriteLine();
    }
}

int[,] GetMatrix(int rows, int columns, int min = 0, int max = 100)
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

void MinNumber(int[,] matr, out int iMin, out int jMin)
{
    int minNumber = matr[0, 0];
    iMin = 0;
    jMin = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < minNumber)
            {
                minNumber = matr[i, j];
                iMin = i;
                jMin = j;
            }
        }
    }
}

int[,] DeleteRowCol(int[,] matrix, int row, int col)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int iNew = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == row) continue;

        int jNew = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == col) continue;

            newMatrix[iNew,jNew] = matrix[i,j];
            jNew++;
        }
        iNew++;
    }
    return newMatrix;
}

int rows = SetNumber("- количество строк");
int columns = SetNumber("- количество столбцов");

int[,] result = GetMatrix(rows, columns);
PrintMatrix(result);
Console.WriteLine();

int row;
int col;
MinNumber(result, out row, out col);

int[,] arr = DeleteRowCol(result, row, col);
PrintMatrix(arr);
Console.WriteLine();
