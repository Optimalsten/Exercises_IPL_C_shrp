// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0,
// и выдаёт номер четверти плоскости,
// в которой находится эта точка.
// 1 четверть (x > 0, y > 0), 2 четверть (x < 0, y > 0),
// 3 четверть (x < 0, y < 0), 4 четверть (x > 0, y < 0).

int GetNumber(string message)
    {
        Console.Write($"Введите координату точки {message}: ");
        int num = Convert.ToInt32(Console.ReadLine());
        return num;
    }

void Show(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine ("\n1 четверть");        
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine ("\n2 четверть");        
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine ("\n3 четверть");        
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine ("\n4 четверть");        
    }
    else if (x == 0 || y == 0)
    {
        Console.WriteLine ("\nДанные некорректны, необходимо, чтобы X <> 0 и Y <> 0."); 
    }
}

Console.WriteLine("\nЗадайте координаты точки (X и Y), причем  причём X </> 0 и Y </> 0, " +
"\nдля определения четверти плоскости, в которой находится эта точка.\n");
Console.Write("Введите X-координату точки: ");
string xPoint = Console.ReadLine();
Console.Write("Введите Y-координату точки: ");
string yPoint = Console.ReadLine();

float xP = float.Parse(xPoint);
float yP = float.Parse(yPoint);
int quart = 0;

if (Math.Abs(xP) <= 0.00001 || Math.Abs(yP) <= 0.00001)
{
    Console.Write($"\nРЕЗУЛЬТАТ: заданные Вами координаты ({xP}; {yP}) - некорректны.\n");
}
else
{
    if (xP > 0 && yP > 0)
    {
        quart = 1;
    }
    else if (xP < 0 && yP > 0)
    {
        quart = 2;
    }
    else if (xP < 0 && yP < 0)
    {
        quart = 3;
    }
    else if (xP > 0 && yP < 0)
    {
        quart = 4;
    }
    Console.WriteLine($"\nРЕЗУЛЬТАТ: точка с координатами ({xP}; {yP}) лежит в {quart} четверти.");
}

// Задержка экрана
// Console.Write("\nДля продолжения нажмите любую клавишу..."); //  "\n - "возврат каретки"
// Console.Read();

Console.WriteLine("\nДалее другой вариант программы (на занятии)...\n"); //  "\n - "возврат каретки"

int numX = GetNumber("X");
int numY = GetNumber("Y");

Show(numX,numY);

// Задержка экрана
Console.Write("\nДля продолжения нажмите любую клавишу..."); //  "\n - "возврат каретки"
Console.Read();

