﻿// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами. m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,] GetArray(int m, int n) {
double [,] arr = new double [m,n];
    for (int i = 0; i < m; i++)
    {
       for (int j = 0; j < n; j++)
       {
        arr[i,j]=new Random().Next(-10,11);
       }
    }
return arr;
}

void PrintArray (double [,] arr)
{
       for (int i = 0; i < arr.GetLength(0); i++)
    {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
        System.Console.Write($"{arr[i,j]} ");
       }
       System.Console.WriteLine();
    }
}

PrintArray (GetArray(3,4));