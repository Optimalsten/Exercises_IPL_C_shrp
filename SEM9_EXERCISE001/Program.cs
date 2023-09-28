void Analis(string[,] array, int i, int j, out int nMistake)
{
    if (array[i,j] == array[i,5]) // выбран правильный ответ
    {
        Console.WriteLine($"Ответ верный. Правильный вариант ответа {j}.");
    }
    else
    {
        int k = 1;
        for (; k < array.GetLength(1)-1; k++)
        {
            if (array[i, k] == array[i, 5])
            {
                break;
            }
        }
        Console.WriteLine($"Ответ неверный. Правильный вариант ответа {k}.");
        nMistake++;
    }
}




int SetNumber(string message)
{
    Console.Write($"Введите число {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

string[,] array =
{
    {"Какие из перечисленных ниже программ являются антивирусными?", "MS Word", "Dr.Web", "Chrome", "PDFreader", "Dr.Web"},
    {"Какого типа графики не существует?", "Растровая", "Векторная", "Облачная", "Трехмерная", "Облачная"},
    {"Когда появился термин «информационные технологии» в современном значении?", "В 1893 году", "В 1990 году", "В 1958 году", "В 1902 году", "В 1958 году"},
    {"В каком году компанией IBM был выпущен первый в истории жесткий диск?", "В 1956 году", "В 1958 году", "В 1955 году", "В 1957 году", "В 1956 году"},
    {"Какая поисковая система была самой популярной в 2011 году?", "Yahoo!", "Google", "Bing", "Yandex", "Google"},
    {"Страна лидер по количеству суперкомпьютеров?", "Китай", "США", "Япония", "Россия", "Китай"},
    {"Какого Интернет-браузера не существует?", "MS PowerPoint", "Opera", "Google Chrome", "Internet Explorer", "MS PowerPoint"},
    {"Какие из клавиш клавиатуры относятся к группе функциональных?", "F1-F12", "CTRL, ALT, Shift", "Windows","Tab",  "F1-F12"},
    {"Какую скорость передачи данных может обеспечить широкополосная связь по ЛЭП?", "200 МБит/с", "1 МБит/с", "100 МБит/с", "10 МБит/с", "100 МБит/с"},
};


bool ind50 = true;
int ansTemp;
int anser;

for (int i = 0; i < array.GetLength(0); i++)
{
    Console.Clear;
    Console.WriteLine($"{array[i,0]} \n\n");

    for (int j = 1; j < array.GetLength(1)-1; j++)
    {
        Console.WriteLine($"{j}. {array[i,j]}");
        if (ind50)
        {
            Console.WriteLine($"\n Для выбора 50х50 введите число 50.");    
        }
        ansTemp = SetNumber(" - выберите вариант ответа");
        if (ansTemp == 50)
        {
            if (ind50)
            {
                Funct50x50(); 
                ind50 = false;
            }
            else
            {
                i--;
                continue;
            }
        }
        Analis(array, i, ansTemp, out int nMistake); // nMistake - кол-во ошибок
        if (nMistake = 2)
        {
            Console.WriteLine($"\n Game over. You have 2 mistake.")
            break;
        }
    }
}

