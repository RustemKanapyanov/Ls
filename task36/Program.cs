// Задача 36: Задайте одномерный массив, заполненный случайными числами
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] A = new int[5];
float s = 0;
Random rnd = new Random();
for (int i = 0; i < 10; i++)
{
    A[i] = rnd.Next(1, 20);
    Console.WriteLine(A[i]);

    if (A[i] % 2 != 0)

        s += A[i];

}
Console.WriteLine("s={0}", s);
Console.ReadKey();