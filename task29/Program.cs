// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
Console.WriteLine("Массив из 8 случайны чисел ");
Random rnd = new Random();
int[] arr = new int[8];
for (int i = 0; i < 8; i++)
{
    arr[i] = rnd.Next();
    Console.WriteLine(arr[i]);
}