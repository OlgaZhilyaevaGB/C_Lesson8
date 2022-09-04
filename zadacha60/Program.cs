﻿/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

Console.Write("введите количество строк в массиве= ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количества столбцов в массиве= ");
int m = int.Parse(Console.ReadLine());
Console.Write("введите количество строк в массиве= ");
int z = int.Parse(Console.ReadLine());

int[,,] GetArray(int n, int m, int z, int minValue, int maxValue)
{
    int[,,] result = new int[n, m, z];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
                result[i, j, k] = new Random().Next(minValue, maxValue + 1) - (i + 1 + j);

        }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"\t{array[i, j, k]}=({i},{j},{k})");
                
            }
            Console.WriteLine();
        }
    }
}

int[,,] myArray = GetArray(n, m, z, 12, 99);
PrintArray(myArray);
Console.WriteLine();

