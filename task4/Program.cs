// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int [] array = new int[3];
int max = 0;
Console.WriteLine("Введите три числа: ");
    for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > array[max])
    {
        max = i;
    }
}
Console.Write("Максимальное введенное число: ");
Console.WriteLine(array [max]);