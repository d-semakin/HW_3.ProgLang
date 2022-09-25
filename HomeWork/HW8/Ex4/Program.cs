// // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы 
// каждого элемента.
// // Массив размером 2 x 2 x 2
// // 66(0,0,0) 25(0,1,0)
// // 34(1,0,0) 41(1,1,0)
// // 27(0,0,1) 90(0,1,1)
// // 26(1,0,1) 55(1,1,1)

int [,,] GetArray (int m, int n, int k)
{
    int [,,] arr = new int [m,n,k];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int z = 0; z < k; z++)
        {
            arr [i,j,z] = new Random().Next(10,100);
        }
    }
}
 return arr;   
}

void PrintArr (int [,,] arr)
{
    for (int z = 0; z < arr.GetLength(2); z++)
    {
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                System.Console.Write($"{arr[i,j,z]} ({i},{j},{z}) ");
            }   
        System.Console.WriteLine(); 
        }
    }
}


PrintArr(GetArray(2,2,2));