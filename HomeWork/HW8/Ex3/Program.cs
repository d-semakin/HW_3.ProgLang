// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] GetArray (int m, int n){
int [,] arr = new  int [m,n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr [i,j] = new Random().Next(0,10);
            }
}
return arr;
}

void PrintArray (int [,] arr)
{
       for (int i = 0; i < arr.GetLength(0); i++)
    {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
        System.Console.Write($"{arr[i,j]} ");
       }
       System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int [,] MultiplicateArr ( int [,] arr1, int [,] arr2)
{
    int [,] multarr = new int [arr1.GetLength(0),arr1.GetLength(1)];
    for (int i = 0; i < multarr.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                multarr[i,j] += arr1[i,k] * arr2[k,j];
            }
    }}
    return multarr;
}

int [,] arr1 = GetArray(2,2);
int [,] arr2 = GetArray(2,2);
int [,] resault = MultiplicateArr(arr1,arr2);


PrintArray (arr1);
PrintArray (arr2);
PrintArray (resault);
