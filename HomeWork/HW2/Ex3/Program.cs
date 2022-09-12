// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void CheckDay (int a){
if (a>0 && a<8){    
System.Console.WriteLine( (a<6) ? $"{a}-й день недели - будний" : $"{a}-й день недели - выходной");
}
else System.Console.WriteLine("Нет такого дня");
}

System.Console.Write("Ведите цифру от 1 до 7 для определения дня недели: ");
int numb = int.Parse(Console.ReadLine());

CheckDay (numb);

// if (numb>0 && numb<8){
//     if (numb<6) {
//         System.Console.WriteLine($"{numb}-й день недели - будний");
//     }
//     else System.Console.WriteLine($"{numb}-й день недели - выходной");
// }
// else System.Console.WriteLine("Неверная цифра. Нет такого дня недели. Запустите программу заново и введите цифру от 1 до 7");

