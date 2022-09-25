﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] Fill(int[,] array)
{
    var SizeX = array.GetUpperBound(0);
    var SizeY = array.GetUpperBound(1);
    var maxX = SizeX+1;
    var maxY = SizeY;
    var dirX = 1;
    var dirY = 1;

    var x = -1;
    var y = 0;
    var val = 1;
    while ((maxX >= 0) && (maxY >= 0))
    {
        for (int xval = 1; xval <= maxX; xval++)
        {
        array[x + dirX * xval, y] = val;
        val++;
        }

        x = x + dirX * maxX;
        dirX = -dirX;
        maxX--;

            for (int yval = 1; yval <= maxY; yval++)
            {
                array[x, y + dirY * yval] = val;
                val++;
            }

            y = y + dirY * maxY;
            dirY = -dirY;
            maxY--;
    }
return array;
}

void PrintArray(int[,] array)
{
for (int j = 0; j < array.GetLength(1); j++)
    {
    for (int i = 0; i < array.GetLength(0); i++)
    Console.Write(" "+array[i,j]);
    Console.WriteLine();
    }
}
var arr = new int[4,4];
arr = Fill(arr);
PrintArray (arr);