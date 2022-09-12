// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube (int n){
    for (int i=1; i <= n; i++)
    {
        System.Console.WriteLine(i*i*i);
    }

}

System.Console.WriteLine("Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

System.Console.Write("Ведите число: ");
int numb = int.Parse(Console.ReadLine());

Cube (numb);