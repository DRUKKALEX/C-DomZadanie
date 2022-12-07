// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int X = Sumcount(num);
Console.WriteLine($"Сумма цифр в числе равна {X}");

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