// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void FillArray (int[] col)
{
    int lenght = col.Length;
    int index = 0;
    while (index < lenght)
  {
        col[index] = new Random().Next(100, 1000);
    index++;
  }

}

void PrintArray(int[] col)
{
int count = col.Length;
int position = 0;
while (position<count)
{
Console.Write(col[position]);
Console.Write(" ");
position++;
}
}

int Count (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++){
        if (arr[i]%2==0)
        count = count+1;
    }
    return count;
}

System.Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());
int [] array = new int [n];


FillArray(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Кол-во четных чисел в массиве - {Count(array)}");

System.Console.WriteLine();
