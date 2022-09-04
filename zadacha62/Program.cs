/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine());

int[,] GetArray(int n, int m)
{
    int[,] result = new int[n, m];
    int k = 1;
    int i = 0;
    int j = 0;

    while (k <= result.GetLength(0) * result.GetLength(1))
    {
        result[i, j] = k;
        k++;
        if (i <= j + 1 && i + j < result.GetLength(1) - 1)
        {
            j++;
        }
        else if (i < j && i + j >= result.GetLength(0) - 1)
        {
            i++;
        }
        else if (i >= j && i + j > result.GetLength(1) - 1)
        {
            j--;
        }
        else
        {
            i--;
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

int[,] myArray = GetArray(n, n);
PrintArray(myArray);
Console.WriteLine();

