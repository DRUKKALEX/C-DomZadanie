// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int X = Sumcount(num);
Console.WriteLine($"Сумма цифр в числе равна {X}");
Console.WriteLine($"Сумма цифр в числе равна {SumCount(num)}");

int Sumcount(int num)
{
    int sum = 0;
    for (int i = 0; num > 0; i++)
    {
        sum = sum + num %10;
        num = num / 10;
    }
    return sum;
}

int SumCount(int num)
    
{
    
    if (num == 0) return 0;
    // sum = sum + num %10;
    // num = num / 10;
    return num %10 + SumCount(num/10);
}


