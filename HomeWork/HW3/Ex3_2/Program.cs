// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

double [] GetQube (int n){
    double [] arr = new double [n];

    for (int i = 1; i <= n; i++)
        {
        arr[i-1]= Math.Pow(i, 3);
        }
    return arr;
}

System.Console.Write("Введите число: ");
    int numb = Convert.ToInt32(Console.ReadLine());

foreach (int num in GetQube(numb))
System.Console.WriteLine(num);