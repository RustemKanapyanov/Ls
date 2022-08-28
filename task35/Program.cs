// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int Massiv = 123;
int[] array = new int[Massiv];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(10, 100);
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i],3}");
}
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 9 && array[i] < 100)
        count++;
}
Console.Write("      Количество Элементов Массива = ");
Console.WriteLine(count);