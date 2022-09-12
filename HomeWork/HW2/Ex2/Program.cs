// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdDigit (int a){
    int resault = 0;
System.Console.WriteLine(Math.Abs(a)>99 ? $"Третья цифра числа {a} - {Math.Abs(a).ToString()[2]}" : "3-ей цифры нет");
}

System.Console.WriteLine("Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
System.Console.Write("Введите число:");
int numb = int.Parse(Console.ReadLine());

ThirdDigit(numb);
