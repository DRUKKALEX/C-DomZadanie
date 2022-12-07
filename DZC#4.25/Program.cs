// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.WriteLine("Введите число A");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int num1 = Convert.ToInt32(Console.ReadLine());
int X = Degnum(num, num1);
Console.WriteLine($"Число A в степени B равно {X}");
int Degnum(int num, int num1)
{
        int result = num;
        for (int i = 1; i < num1; i++)
        {
        result = result*num;
        }
        return result;
}

