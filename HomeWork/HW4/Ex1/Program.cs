// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Pow (int a, int b)
{
    
    double result = Math.Pow(a, b);
    return result;
}

System.Console.Write("Введите число a: ");
    int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b: "); 
    int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Число {a} в степени {b} = {Pow(a,b)}");