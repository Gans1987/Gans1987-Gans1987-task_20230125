﻿//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Не использовать строки для расчета.

int n = 67128;
if (n > 99)
{
    Console.Write($"Третья цифра числа {n} = ");
    while (n > 99)
        n /= 100;
    Console.WriteLine(n % 10);
}
else
{
    Console.WriteLine("Третье цифры нет");
}
Console.ReadKey();