// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество
//чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int[] rendr(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(100, 1000);
        Console.Write($"{array[i]} "); 
    }
    return array;
}
int len = 4;
int[] array = rendr(len);
int FindCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < 4; i++)
    {
        if ((array[i] % 2) == 0)
        {
            count = count + 1;            
        }
    }
    return count;
}
Console.WriteLine("");
Console.WriteLine($"{FindCount(array)}");



