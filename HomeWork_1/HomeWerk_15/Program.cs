//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int Inputnt(string massage)
{
     System.Console.WriteLine($"{massage}: ");
     return int.Parse(Console.ReadLine()!);
}   

int[] CreateArray(int len)
{
     int[] array = new int[len];
     for (int i = 0; i < array.Length; i++)
     {
        array[i] = new Random().Next(100, 1000);
     }
      
         return array;
}
 void PrintArray(int [] array)
 {
       foreach (var item in array)
      {
        System.Console.Write($"{item}, ");
      }
      System.Console.WriteLine();
 }
 int CountEvenNumbers(int[] array)  
 {
    Int16 count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 ==0)
        {
            count++;
        }
    }   
    return count;
 }

int len = Inputnt("Введите длину массива");
int[] array = CreateArray(len);
PrintArray(array);
System.Console.WriteLine($"Количиство четных чисел в массиве: {CountEvenNumbers(array)}");