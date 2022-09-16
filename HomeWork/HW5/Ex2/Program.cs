// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FeelArr (int[] arr)
{
    int lenght = arr.Length;
    int i = 0;
    while (i<lenght)
    {
        arr[i]=new Random().Next (1,10);
        i++;
    }

}

void Print (int[] arr){
    int i=0;
    int length=arr.Length;
    while (i<length){
        System.Console.Write($"{arr[i]} ");
        i++;}
        
    }

int Amount (int [] arr){
        int length = arr.Length;
        int amount = 0;
    for (int i = 0; i < length; i=i+2)
    {
        amount += arr[i];
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Сумма всех чисел, cтоящих на нечетных позициях массива равна {amount}.");
    return amount;
}

System.Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int [] arr = new int [n];

FeelArr(arr);
Print(arr);
Amount(arr);
