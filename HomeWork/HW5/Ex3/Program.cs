// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double [] FeelArr (int length){
       double [] arr = new double [length];
       for (int i = 0; i < length; i++)
    {
        arr[i]= new Random().Next(0,100)/10.0;
    }
    return arr;
}

// void PrintArr(double [] arr){
//     int length=arr.Length;
//     for (int i = 0; i < length; i++)
//     {
//         System.Console.Write($"{arr[i]} ");
//     }
// }

double Diff (double [] arr){
    int length = arr.Length;
    double max=arr[0];
    double min=arr[0];
    for (int i = 1; i < length; i++)
    {

        if (arr[i]>max)
        {
            max=arr[i];
        }
        if (arr[i]<min)
        {   
            min=arr[i];
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Максимальное число в массиве: {max}");
    System.Console.WriteLine($"Минимальное число в массиве: {min}");
    System.Console.WriteLine($"Разница между максимальным и минимальным числом в массиве: {max-min}");
    return max-min;
}

System.Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());

double [] arr = FeelArr(length);
System.Console.WriteLine(string.Join("    ", arr));
// PrintArr(arr);
Diff(arr);