Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int first = num / 10000;
int second = num % 10000 / 1000;
int fourth = num % 100 / 10;
int fifth = num % 10;
if (first == fifth && second == fourth)
    Console.WriteLine($"Число {num} является палиндромом");
else
    Console.WriteLine($"Число {num} не является палиндромом");
