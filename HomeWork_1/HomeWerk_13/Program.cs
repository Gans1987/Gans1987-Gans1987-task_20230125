//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции.
//452 -> 11
//82 -> 10
//9012 -> 12*/

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumber(int numberN)
{
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = numberN % 10;
        result = result + (advance);
        numberN = numberN / 10;
    }
    return result;
}

int SumNumber = SumNumber(numberN);