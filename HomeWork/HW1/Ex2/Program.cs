// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

Console.WriteLine("Программа определяет какое из трех числел максимальное.");
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());
int max=number1;
    if (number2 > max)
    {
    max=number2;
    }
   if (number3 > max)
    {
    max=number3;
    }
    System.Console.WriteLine($"Максимальное число {max}");

// Эта же задача через массив
// Массив задан
// int a=3;
// int b=5;
// int c=7;
// int max1=a;
// int[] arr = new int[3]{a, b, c};


// Ввод массива
// System.Console.WriteLine("Введите размер массива");
// // int len = Convert.ToInt32(Console.Read());
int [] arr = new int[3];
int max1=arr[0];


for (int i = 0; i<arr.Length; i++){
    System.Console.Write("Введите ", i, " элемент");
    System.Console.Write(i);
    System.Console.Write(" элемент ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

foreach (int element in arr)
{
    System.Console.Write(element);
    Console.Write(" ");
}

    for (int i=0; i < arr.Length; i++)
        if (arr[i]>max1)
{        max1=arr[i];}

System.Console.Write("Максимальный элемент ");
System.Console.WriteLine(max1);