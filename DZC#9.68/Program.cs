// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Напишите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{M}  {N} -> {AkkRec(M, N)}");

int AkkRec( int M, int N)
{
    if (M == 0) return N + 1;
    if(M != 0 &&  N == 0) return AkkRec(M-1, 1);
    if(M > 0 && N > 0) return AkkRec(M -1, AkkRec(M, N - 1));
  return AkkRec(M, N);
}