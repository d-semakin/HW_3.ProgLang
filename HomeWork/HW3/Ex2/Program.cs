// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double FindDistnce (int x1, int y1, int z1, int x2, int y2, int z2){
return Math.Abs(Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2)+ Math.Pow((z1-z2), 2)));
}

System.Console.WriteLine(FindDistnce(3,6,8,2,1,-7));
System.Console.WriteLine(FindDistnce(7,-5,0,1,-1,9));
