void FillArray (int[] col)
{
    int lenght = col.Length;
    int index = 0;
    while (index < lenght)
  {
        col[index] = new Random().Next(1, 10);
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


System.Console.WriteLine("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());
int [] array = new int [n];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
