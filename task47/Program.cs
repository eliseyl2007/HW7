﻿/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/



double[,] CreatMatrixRndDouble(int rows,int columns, double min, double max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
        }

    }
    return matrix;
}

void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("]");
    }
}

Console.WriteLine("Введите количество строк");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбов");
int columns1 = Convert.ToInt32(Console.ReadLine());

double[,] array2d = CreatMatrixRndDouble(rows1, columns1, -100, 100);
PrintMatrixDouble(array2d);

