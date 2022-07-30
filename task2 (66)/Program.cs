/* Задача 66: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 */


int AckerFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return AckerFunc(m - 1, 1);
    return AckerFunc(m - 1, AckerFunc(m, n - 1));
}

void PrintFunc(int m, int n)
{
    Console.WriteLine(AckerFunc(m, n));
}

PrintFunc(2, 3);