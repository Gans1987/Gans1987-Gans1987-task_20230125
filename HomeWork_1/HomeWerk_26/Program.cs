// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

static void F(int m, int n)
{
    if (m <= n)
    {
        if (m % 2 == 0)
            Console.Write("{0} ", m);
        F(m + 1, n);
    }
}

int m = 1;
int n = 5;
F(m, n);
Console.ReadKey();
