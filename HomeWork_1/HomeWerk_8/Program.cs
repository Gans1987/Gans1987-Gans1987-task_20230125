///Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int num = 54345;
int mun = 0;
int multi = 10000;
int n = num;
while (n > 0)
{
    mun += n % 10 * multi;
    n /= 10;
    multi /= 10;
}
Console.WriteLine(mun == num ? "да" : "нет");
Console.ReadKey();