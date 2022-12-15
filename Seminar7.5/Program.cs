// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
//  находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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
int DiagSum(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (i == j)
                sum = sum + array[i, j];
    }
    return sum;
}

int DiagSum2(int[,] array)
{
    int sum = 0;
    for (int i = array.GetLength(0)-1; i >= 0; i--)
    {
        for (int j = 0; j < array.GetLength(1); j++)
          if (j == array.GetLength(0) - i)

            sum = sum + array[i, j];
    }
    return sum;
}
Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
Console.WriteLine($"сумма элементов на диагонали {DiagSum(array)}");
Console.WriteLine($"сумма элементов на обратной диагонали {DiagSum2(array)}");


// int DiagSum3(int[,] array)
// {
//     int sum = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = array.GetLength(1) - 1; j >= 0; j--)
//         {
//             if (j == (array.GetLength(1) - 1-i))
//                 sum = sum + array[i, j];
//         }
//     }
//     return sum;
// }

// void Fill2DArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-10, 10);
//         }
//     }
// }

// void PrintTable(int[,] table)
// {
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             Console.Write($"{table[i, j],3}\t");
//         }
//         Console.WriteLine();
//     }
// }

// void Summ(int[,] table)
// {
//     int sum = 0;
//     int sum2 = 0;
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {

//             if (i == j) sum = table[i,j] + sum;
//             if (table.GetLength(0) - i - 1 == j) sum2 = table[i,j] + sum2;
        
//         }
//     }
//     Console.WriteLine($"{sum}");
//     Console.WriteLine($"{sum2}");
// }

// Console.WriteLine("Колличество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Колличество столбцов");
// int colums = Convert.ToInt32(Console.ReadLine());

// int[,] table = new int[rows, colums];
// Fill2DArray(table);
// PrintTable(table);
// Summ(table);