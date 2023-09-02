// Задача № 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3   ->  Среда
// 5   ->  Пятница

Console.Write("Введите номер дня недели: ");
string strNum = Console.ReadLine();
int WeekDay = int.Parse(strNum);

if (WeekDay == 1)
{
    Console.WriteLine("Понедельник");
}

else if (WeekDay == 2)
{
    Console.WriteLine("Вторник");
}

else if (WeekDay == 3)
{
    Console.WriteLine("Среда");
}

else if (WeekDay == 4)
{
    Console.WriteLine("Четверг");
}

else if (WeekDay == 5)
{
    Console.WriteLine("Пятница");
}

else if (WeekDay == 6)
{
    Console.WriteLine("Суббота");
}

else if (WeekDay == 7)
{
    Console.WriteLine("Воскресенье");
}

else
{
    Console.WriteLine("Вы ввели некорректный номер дня недели !");
}
