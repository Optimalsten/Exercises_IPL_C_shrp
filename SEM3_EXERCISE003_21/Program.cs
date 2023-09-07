// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21.

int GetNumber(string message)
{
    Console.Write($"Введите координату {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

Console.WriteLine("\nВведите координаты двух точек (X, Y)" +
"\nдля определения растояния между ними в 2-хмерном пространстве.\n");
int numX1 = GetNumber("X (для 1-ой точки)");
int numY1 = GetNumber("Y (для 1-ой точки)");
int numX2 = GetNumber("X (для 2-ой точки)");
int numY2 = GetNumber("Y (для 2-ой точки)");

double numX = Math.Pow((numX2 - numX1), 2);
double numY = Math.Pow((numY2 - numY1), 2);

double result = Math.Sqrt(numX + numY);

Console.WriteLine($"\nРезультат равен {Math.Round(result, 3)}.");

// Задержка экрана
Console.WriteLine("\nДля продолжения нажмите любую клавишу..."); //  "\n - "возврат каретки"
Console.Read();
