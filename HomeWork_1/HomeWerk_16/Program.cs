// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 26
//[-4, -6, 4, 6] -> 0

int InputInt(string message)
{
    System.Console.WriteLine($"{message}");
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int len)
{
     int[] array = new int[len];
     for (int i = 0; i < array.Length; i++)
     {
        array[i] = new Random().Nex(1, 100);
     }
     return array;
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write($"{item}, ");
    }
    System.Console.WriteLine();
}

int SumOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int len = InputInt("Введите длину массива");
int[] array = CreateArray(len);
PrintArray(array);
System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {CountSum(array)}");