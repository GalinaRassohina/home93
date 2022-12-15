// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
int Ackerman(int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return Ackerman(M - 1, 1);
    if (M > 0 && N > 0) return Ackerman(M - 1, Ackerman(M, N - 1));
return Ackerman(M, N);
}
int M = 4;
int N = 8;
int result = Ackerman(M,N);
Console.WriteLine(result);