// Задача 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i = -1 * a;
Console.WriteLine(i);
for (;i <= a; i++)
{
    Console.WriteLine(i);
    Console.WriteLine("");
}