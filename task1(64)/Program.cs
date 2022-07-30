/* Задача 64: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
int sum = 0;
void SumFunc(int M, int N)
{
    if (M > N)
        return;
    System.Console.Write(M + " ");
    sum += M;
    SumFunc(M + 1, N);
}

SumFunc(4, 10);
System.Console.WriteLine();
System.Console.WriteLine("сумму натуральных элементов в промежутке от M до N равна: " + sum);