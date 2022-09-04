/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

Console.Write("введите количество строк в массиве n= ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количества столбцов в массиве m= ");
int m = int.Parse(Console.ReadLine());


int[,] GetArray(int n, int m, int minValue, int maxValue)
{
    int[,] result = new int[n, m];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write("{0,4}", array[i, j]);
        Console.WriteLine();
    }
}

void SortArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(1); k++)
            {
                if (inArray[i, j] >= inArray[i, k])
                {
                    int temp = inArray[i, j];
                    inArray[i, j] = inArray[i, k];
                    inArray[i, k] = temp;
                }
            }
        }
    }
    for (int i = 0; i < inArray.GetLength(0); i++, Console.WriteLine())
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write("{0,4}", inArray[i, j]);
        }
    }

}

int[,] myArray = GetArray(n, m, 1, 10);
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine("После сортировки:");
SortArray(myArray);

