// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.


int [] FillArray(int[] myArray);
{
    int [] myArray = new int [8];
    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine("Введите элемент массива: , i + 1");
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return myArray;
}
void PrintArray (int[] myArray)
{
    for(i = 0; i < 8; i++)
    {
    Console.WriteLine(myArray[i]);
    }
}

int [] myArray = FillArray(myArray);
Console.WriteLine("Вывод массива");
PrintArray(new int [8]);

