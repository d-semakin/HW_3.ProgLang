// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double [] CheckDot (double b1, double k1, double b2, double k2)
    {
        if (k1==k2){
            System.Console.WriteLine("Прямые не пересекаются");
        }
    double [] res = new double [2];
    res [0] = (b2-b1)/(k1-k2);
    res [1] = k1*res[0] + b1;
    System.Console.WriteLine($"Точка пересечения прямых [{string.Join(" ,", res)}].");
    return res;
    }

System.Console.WriteLine("Введите коэффициент b1, k1, b2, k2 через enter");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());

CheckDot (b1, k1, b2, k2);