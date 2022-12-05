Console.WriteLine("Введите номер дня недели:");

string dayStr = Console.ReadLine() ??"";

bool isNum = int.TryParse(dayStr, out int day);

if (!isNum) 
{
    Console.WriteLine("Надо ввести номер дня недели");
    return;
}

//int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7)
    Console.WriteLine("Нет такого дня недели");
else
{
    if (day == 6 || day == 7)
        Console.WriteLine($"День {day} является выходным");
    else 
        Console.WriteLine($"День {day} не является выходным");
}    

