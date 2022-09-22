// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double [] ArrMean (int [,] arr){
    // int [] temp = new int [arr.GetLength(1)];
   
    double [] arrMean = new double [arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {    double count=0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            count = count + arr[i,j];
        }
                   System.Console.WriteLine($"Среднее арифмитическое столбца {j+1}: {Math.Round(count/arr.GetLength(0), 1)}");
        }

    // for (int i = 0; i < arr.GetLength(1); i++)
    // {
    //     arrMean[i] = temp[i]/arr.GetLength(0);
    
    return arrMean;
}


int [,] arr = GetArray(3,4);
PrintArr(arr);
double [] newarr = ArrMean (arr);

System.Console.WriteLine();


