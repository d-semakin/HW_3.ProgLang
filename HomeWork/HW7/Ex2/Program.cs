// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// вводим позиции по i и j -> если таких нет - выводим, что позиции не существует.


int [,] GetArray (int m, int n) {
int [,] arr = new int [m,n];
    for (int i = 0; i < m; i++)
    {
       for (int j = 0; j < n; j++)
       {
        arr[i,j]=new Random().Next(-10,11);
       }
    }
return arr;
}

void PrintArr (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
      {
           System.Console.Write($"{arr[i,j]} "); 
        
    }
    System.Console.WriteLine();}
}

void SearchElement (int [,] arr, int m, int n){
if (m-1>arr.GetLength(0) || n-1>arr.GetLength(1)){
    System.Console.WriteLine("Искомого элемента нет в массиве");}
else {System.Console.WriteLine($"Элемент с индексом [{m}, {n}]: {arr[m-1,n-1]}");}
}


int [,] arr = GetArray(3,4);
PrintArr(arr);

System.Console.WriteLine("Введите номер строки искомого элемента: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите номер столбца искомого элемента: ");
int n = Convert.ToInt32(Console.ReadLine());

SearchElement( arr,m,n);