// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
{
    Console.WriteLine("Введите число: ");
    string str = Console.ReadLine();
    int n = Convert.ToInt32(str);
    int count = 0;
        while (n > 0)
    {
    count++;
    n = n / 10;
    }
     Console.WriteLine("Данное число содержит цифр: " + count);
}