// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 99)
{
    Console.WriteLine(Convert.ToString(a)[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if (number < 100)
{
    Console.WriteLine("В числе нет третьей цифры");
}
else
{
    while (number >= 1000)
    {
        number /= 10;
    }
    int digit3 = number % 10;
    Console.WriteLine(digit3);
}

Console.Write("Введите число ");
string numberStr = Console.ReadLine();
int digitIndex = 2;

if (numberStr[0] == '-')
{
    digitIndex++;
}
if (numberStr.Length < digitIndex + 1)
{
    Console.WriteLine("В числе нет третьей цифры");
}
else
{
    Console.WriteLine(numberStr[2]);
}