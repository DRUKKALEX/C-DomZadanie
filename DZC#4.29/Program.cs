// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.


int [] FillArray()
{
    int [] myArray = new int [8];    
    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine("Введите элемент массива: ");
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return myArray;
}
void PrintArray (int [] myArray)
{
    for (int i = 0; i < 8; i++)
    {
    Console.Write($"{myArray[i]} ");
    }
}

int [] myArray = FillArray();
Console.WriteLine("Вывод массива");
PrintArray(myArray);

