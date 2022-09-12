// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void SecondDigit (int numb){
System.Console.WriteLine(Math.Abs(numb)>99 && Math.Abs(numb)<1000 ? $"Вторая цифра: {(Math.Abs(numb) %100)/10}" : "Вы ввели неверное число");
}

System.Console.WriteLine("Программа принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
System.Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());

SecondDigit(a);