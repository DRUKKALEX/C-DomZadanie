Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99) 
{
while (num > 999) num = num / 10;

Console.Write($"{(num%10)}");
}
else
Console.WriteLine("Третьей цифры нет");


