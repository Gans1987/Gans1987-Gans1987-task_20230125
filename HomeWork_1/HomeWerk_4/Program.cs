﻿///Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int N = 20;
for (int i = 2; i <= N; i += 2)
    Console.WriteLine($"{i} ");
Console.ReadKey();