///Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
///Реализовать через функции.

static double Power(double a, int b)
{
    double res = a;
    for (int i = 1; i < b; i++)
        res *= a;
    return res;
}

Console.WriteLine(Power(3, 5));
Console.ReadKey();
