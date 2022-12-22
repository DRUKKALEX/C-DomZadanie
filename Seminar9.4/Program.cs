// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число A");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int num1 = Convert.ToInt32(Console.ReadLine());
int X = Degnum(num, num1);
Console.WriteLine($"Число A в степени B равно {X}");
Console.WriteLine($"Сумма цифр в числе равна {Degnumum1(num, num1)}");
int Degnum(int num, int num1)
{
        int result = num;
        for (int i = 1; i < num1; i++)
        {
        result = result*num;
        }
        return result;
}
int Degnumum1(int num, int num1)
    
{
    
    if (num == 0) return 0;
    // sum = sum + num %10;
    // num = num / 10;
    return num  * Degnumum1(num);
}



// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

Console.WriteLine("Введите основание");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PowRec(numberA, numberB));


int Pow(int numberA, int numnerB)
{
    int result = 1;
    while (true)
    {
        result *= numberA;
        numnerB--;
        if (numnerB == 0)
            break;
    }
    return result;
}
// int result = 1;
// for (int i = 0;i<numberB;i++)
//     result= result*numberA;



int PowRec(int numberA, int numberB)
{
    if (numberB == 0) return 1;
    return numberA * PowRec(numberA, numberB - 1);
}

// numberA * (numbarA * (numberA*(1)))

