// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.WriteLine("Программа определяет какое число больше, а какое меньше.");
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
{
    if (number1 == number2)
    {
        System.Console.WriteLine("Числа равны");
    }
    else if (number1 > number2)
    {
    System.Console.WriteLine($"Число {number1} больше, число {number2} меньше.");
    }
    else System.Console.WriteLine($"Число {number2} больше, число {number1} меньше.");
}