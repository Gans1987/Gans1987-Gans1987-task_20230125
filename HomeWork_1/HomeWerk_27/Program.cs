// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

static int F(int m, int n)
{
    if (m <= n)
    {
        return m + F(m + 1, n);
    }
    return 0;
}

int m = 4;
int n = 8;
Console.WriteLine(F(m, n));
Console.ReadKey();