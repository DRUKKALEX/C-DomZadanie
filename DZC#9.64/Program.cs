// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

Console.Write("Введите целое число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Все натуральные числа в промежутке от {N} до 1; {Posled(N)}");

string Posled(int N)
{
    if (N == 1) return Convert.ToString(1);
    return Convert.ToString(N) + "," + Posled(N - 1);
}
