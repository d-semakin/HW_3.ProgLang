// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Polyndrom1 (int n)

{
    if (n % 10 == n/ 10000 && (n%100)/10 == (n/1000) % 10)
    {
    return true;}
    else 
    {return false;}
}

System.Console.WriteLine(Polyndrom1(14212));
System.Console.WriteLine(Polyndrom1(12821));
System.Console.WriteLine(Polyndrom1(23432));