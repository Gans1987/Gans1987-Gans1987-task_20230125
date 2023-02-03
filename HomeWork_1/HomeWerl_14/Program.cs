//Напишите программу,
//которая задает массив из 8 элементов и выводит их на экран.

Random rnd = new Random();
static void ShowRandomIntArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue + 1);
        Console.Write(arr[i].ToString() + (i + 1 < len ? ", " : ""));
    }
}

ShowRandomIntArray(8, 1, 8);