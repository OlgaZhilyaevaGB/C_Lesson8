/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

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
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

void MinRowsSum(int[,] array)
{
    int index = 0, minsum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            summ += array[i, j];
        }
        if (i == 0)
        {
            minsum = summ;
        }
        else if (summ < minsum)
        {
            minsum = summ;
            index = i;
        }
    }
    string rows = string.Empty;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        rows += array[index, j] + " ";
    }
    Console.WriteLine($"Строка с минимальной суммой {minsum} элементов равна {index+1}. ");
}

int[,] myArray = GetArray(n, m, 0, 10);
PrintArray(myArray);
Console.WriteLine();
MinRowsSum(myArray);


