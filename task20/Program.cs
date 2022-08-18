// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D
// A(3,6); B(2,1) -> 5.09
// A(7, -5); B (1, -1) -> 7,21
Console.WriteLine("Ведите координату точки А по Х");
int xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите координату точки А по Y");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите координату точки B по Х");
int xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите координату точки B по Y");
int yb = Convert.ToInt32(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
res = Math.Round(res, 2);

Console.WriteLine($"{res}");
