/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

Console.Write("введите количество строк в первой матрице:");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Введите количества столбцов в первой матрице: ");
int m1 = int.Parse(Console.ReadLine());
Console.Write("введите количество строк во второй матрице: ");
int n2 = int.Parse(Console.ReadLine());
Console.Write("Введите количества столбцов во второй матрице: ");
int m2 = int.Parse(Console.ReadLine());

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

void ProizvArray(int[,] first, int[,] second, int[,] resArray)
{
  for (int i = 0; i < resArray.GetLength(0); i++)
  {
    for (int j = 0; j < resArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < first.GetLength(1); k++)
      {
        sum += first[i,k] * second[k,j];
      }
      resArray[i,j] = sum;
    }
  }
}

int[,] OneArray = GetArray(n1, m1, 0, 10);
PrintArray(OneArray);
Console.WriteLine();
int[,] TwoArray = GetArray(n2, m2, 0, 10);
PrintArray(TwoArray);
int[,] resultMatrix = new int[n1, m2];
Console.WriteLine();
ProizvArray(OneArray, TwoArray, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatrix);

