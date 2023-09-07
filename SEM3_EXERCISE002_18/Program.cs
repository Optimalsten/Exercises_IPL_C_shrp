// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает
// диапазон возможных координат точек в этой
// четверти (x и y).


// int quarter = GetNumber("quarter");
// const int num2 = 1 ;

int GetNumber(string message)
{
    Console.Write($"\nВведите четверть : ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void Show(int quarter)
{
    switch (quarter)
    {
        case 1:
            {
                Console.WriteLine("\nx > 0,  y > 0");
                break;
            }
        case 2:
            {
                Console.WriteLine("\nx < 0,  y > 0");
                break;
            }
        case 3:
            {
                Console.WriteLine("\nx < 0,  y < 0");
                break;
            }
        case 4:
            {
                Console.WriteLine("\nx > 0,  y < 0");
                break;
            }
        default:
            {
                Console.WriteLine("\nВведена неправильная четверть");
                break;
            }
    }
}

int numX = GetNumber("");
Show(numX);

// Задержка экрана
Console.Write("\nДля продолжения нажмите любую клавишу..."); //  "\n - "возврат каретки"
Console.Read();
