///Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

double a = 10;
double b = 20;
if (a < b)
{
    Console.WriteLine($"Max = {b}");
    Console.WriteLine($"Min = {a}");
}
else if (b < a)
{
    Console.WriteLine($"Min = {a}");
    Console.WriteLine($"Max = {b}");
}
else
{
    Console.WriteLine("Число {b} ровно числу {a}");
}
Console.ReadKey();
