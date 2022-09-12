//Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// Немного поменял условия задачи, необходимо ввести 2 числа. Но в таком случае 

System.Console.WriteLine("Программа покажет все четные числа в диапазоне введеных чисел.");
System.Console.WriteLine("Введите число 1");
int num1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число 2");
int num2 = int.Parse(Console.ReadLine());
        
if (num2 > num1)
    {
    System.Console.Write($"Четные числа в диапазоне {num1} - {num2}: ");
    for (int i = num1; i <= num2; i++)
        if (i==0)
        continue;
        else if (i % 2 == 0)
        System.Console.Write(i + " ");
    }
else if (num1 > num2)
    {
    System.Console.Write($"Четные числа в диапазоне {num2} - {num1}: ");       
    for (int i = num2; i <= num1; i++)
        if (i==0)
        continue;
        else if (i % 2 == 0)
        System.Console.Write(i + " ");
    }
else System.Console.WriteLine("Диапазон отсутствует.");