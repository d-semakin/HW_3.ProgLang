// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
// суммой элементов: 1 строка.

int [,] GetArray (int m, int n){
int [,] arr = new  int [m,n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr [i,j] = new Random().Next(0,3);
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

int NumberMinStringAmount (int [,] arr) {
        int minStringAmount=0;
        int stringResault = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            minStringAmount += arr[0,j];
        }
        System.Console.WriteLine($"Сумма элементов 1-й строки: {minStringAmount}");
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int stringAmount =0;
                for (int j = 0; j < arr.GetLength(1); j++)
        {
            stringAmount += arr[i,j];
            
        }
        System.Console.WriteLine($"Сумма элементов {i+1}-й строки: {stringAmount}");
        if (stringAmount<minStringAmount)
        {minStringAmount=stringAmount;
        stringResault = i;}
        }
    System.Console.WriteLine($"Номер строки с минимальной суммой элементов: {stringResault+1}.");
    return stringResault;
}

int [,] array = GetArray(5,4);

PrintArray (array);
NumberMinStringAmount(array);