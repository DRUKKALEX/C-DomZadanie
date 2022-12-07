// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и 
//т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

int[] CreateArray(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
        array[i] = new Random().Next(-5, 5);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

int [] Proizved(int[] array)
{
    int N = array.Length;
    int[]Array1 = new int[N/2+N%2];
    //if (N%2 == 0) int Array1 = new int [N/2];
    //else int Array1 = new int [(N/2)+1];
    
    for (int i = 0; i < N/2+N%2; i++ )
    {
        Array1[i] = array[i] * array[N-1-i]; 
                
    }
    return Array1;
}   

Console.WriteLine("Введите размерность массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(N);
PrintArray(array);
Console.WriteLine("Вот измененный массив");
//Zamena(array);
//Console.WriteLine($"{Zamena(array)}");
PrintArray(Proizved(array));
//PrintArray(Array1);

