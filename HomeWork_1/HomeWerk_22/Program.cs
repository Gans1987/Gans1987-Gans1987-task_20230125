// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
// 



double[,] GetArray(int m, int n, int minValue, int mixValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)

    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * (mixValue - minValue) + minValue, 2);

        }
    }
    return result;
}

// Выводим массив в консоль 

void WriteArrayToConsole(double[,] doubleArray)
{
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            Console.Write($"{doubleArray[i, j]}\t");
        }
    }
}
// Сортировка строк массива пузырков
double[,] SortRows(double[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
        for (int i = 0; i < matrix.GetLength(1); i++)
            for (int j = matrix.GetLength(1) - 1; j > i; j--)
                if (matrix[rows, j] > matrix[rows, j - 1])
                {
                    double tmp = matrix[rows, j];
                    matrix[rows, j] = matrix[rows, j - i];
                    matrix[rows, j - 1] = tmp;
                }
    return matrix;
}

int rows =3;
int columns = 5;
double[,] d_array = GetArray(rows, columns, -10, 10);
System.Console.WriteLine("Изначальный массив: ");
WriteArrayToConsole(d_array);
System.Console.WriteLine("\nОтсортированный: ");
WriteArrayToConsole(SortRows(d_array));
