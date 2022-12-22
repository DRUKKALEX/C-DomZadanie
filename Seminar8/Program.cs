// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j], 3}\t");
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-20, 21);
}
void Replace(int[,] array)
{
    int[] tmp = new int[ array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
            tmp[i] = array[0,i];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        array[0,i] =array[array.GetLength(0)-1,i];
        array[array.GetLength(0)-1,i]=tmp[i];
    }
           
}

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
Replace(array);
Console.WriteLine();
PrintArray(array);
