// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.
int len = 8;
int[] array = new int [len];

for (int i = 0; i < len; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"{array[i]} ");
}
Console.WriteLine($"введите восемь произвольных цифр");
Console.WriteLine();

