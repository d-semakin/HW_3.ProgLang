// Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumber(number, 1));

string PrintNumber(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return (start + ", " + PrintNumber(start-1, end));    
}

//Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
//промежутке от M до N.


Console.WriteLine("Введите два числа:");
int numberFirst = Convert.ToInt32(Console.ReadLine());
int numberSecond = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumberSum(numberFirst, numberSecond));

int PrintNumberSum(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    return (start + PrintNumberSum(start+1,end));
}

//Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите два неотрицательных числа");
int numberM = Convert.ToInt32(Console.ReadLine());
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CalculateFunction(numberM, numberN));

int CalculateFunction(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m > 0) && (n == 0))
      return CalculateFunction(m - 1, 1);
    else
      return CalculateFunction(m - 1, CalculateFunction(m, n - 1));
}





