// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел происходит через Enter, останавливается при введении слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Первое решение - пользователь вводит ограничение по кол-ву вводимых чисел и вводит их вручную.
int [] NewArr ()
{
    System.Console.WriteLine("Введите кол-во проверяемых чисел: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int [] arr = new int[n];
    // System.Console.WriteLine($"Введите {n} чисел по одному нажимая Enter после каждого.");
    for (int i = 0; i < n; i++)
    {
         System.Console.WriteLine($"Введите {i+1}-e число и нажмите Enter: ");
         arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void CheckNumbers (int [] arr)
{
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]>0 )
    {
        count += 1;
    }
}
System.Console.WriteLine($"Кол-во положительных чисел среди {string.Join (" ,", arr)} равно {count}.");
}


int [] arr= NewArr();
CheckNumbers (arr);
