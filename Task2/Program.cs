Console.WriteLine("Введите число:");

string numStr = Console.ReadLine() ??"";

bool isNum = int.TryParse(numStr, out int num);

if (!isNum) 
{
    Console.WriteLine("Вы ввели не число");
    return;
}

num = Math.Abs(num);
if (num < 100)
    Console.WriteLine("в веденном числе нет третьей цифры");    
else
    Console.WriteLine($"Третья цифра во введенном числе = {num.ToString()[2]}");