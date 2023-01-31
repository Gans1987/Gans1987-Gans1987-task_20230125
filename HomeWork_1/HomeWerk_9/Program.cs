//Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Ax = 3;
double Ay = 6;
double Az = 8;
double Bx = 2;
double By = 1;
double Bz = -7;

double distance3D = Math.Sqrt(Math.Pow(Math.Abs(Ax - Bx), 2) +
                              Math.Pow(Math.Abs(Ay - By), 2) +
                              Math.Pow(Math.Abs(Az - Bz), 2));

Console.WriteLine($"Росстояние между тщчками " +
                  $"A({Ax};{Ay};{Az}) и B({Bx};{By};{Bz}) = {distance3D:#.##}");
Console.ReadKey();