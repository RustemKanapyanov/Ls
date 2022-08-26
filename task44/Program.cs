// Задача 44: Не используя рекурсию, 
// выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.WriteLine("Номер элемента ряда Фибоначчи: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintFibToN(N);
void PrintFibToN(int N)
{
    Console.WriteLine("0 1 "); //последовательность начинается с 0 и 1
    int neigbour1 = 0;
    int neigbour2 = 1; 
    for (int i = 0; i < N -2; i++)
    {
        int res = neigbour1 + neigbour2;
        Console.Write (res + " ");
        neigbour1 = neigbour2;
        neigbour2 = res;
    }
}