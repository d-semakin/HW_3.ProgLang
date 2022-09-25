// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



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

int [,] SortBySize (int [,] arr){
    int temp = 0;
    
for (int i = 0; i < 3; i++)
{
        
    for (int k = 0; k < arr.GetLength(1); k++)
        {
        for (int j = 0; j < (arr.GetLength(1)-1); j++)
       {  
        if (arr[i,j]<arr[i,j+1])
        {
            temp = arr[i,j];
            arr[i,j] = arr[i,j+1];
            arr[i,j+1] = temp;
        }
        }
        }
}
return arr;
}

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

int [,] arr = GetArray(3,4);

System.Console.WriteLine("Оригинальный массив");
PrintArray (arr);
System.Console.WriteLine("Отсортированный массив");
PrintArray(SortBySize(arr));