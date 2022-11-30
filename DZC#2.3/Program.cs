Console.WriteLine("Введите число, обозначающее день недели");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 1 && num <= 5)
Console.WriteLine("нет");
else
Console.WriteLine("да");