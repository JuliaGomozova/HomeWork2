Console.WriteLine("Введите трехзначное число:");

string numStr = Console.ReadLine() ??"";

bool isNum = int.TryParse(numStr, out int num);

if (!isNum) 
{
    Console.WriteLine("Вы ввели не число");
    return;
}

num = Math.Abs(num);
if (num < 100 || num > 999)
    Console.WriteLine("Введенное число не является трехзначным");    
else
    Console.WriteLine($"Вторая цифра во введенном числе = {num.ToString()[1]}");