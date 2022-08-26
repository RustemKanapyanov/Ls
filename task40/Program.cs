// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите сторону a ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите сторону b ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите сторону c ");
int c = Convert.ToInt32(Console.ReadLine());

bool res = IsTriangleExist(a, b, c);
if (res == true)
{
    Console.WriteLine("Треугольник с заданными сторонами может существать ");
}
else
{
    Console.WriteLine("Треугольник с заданными сторонами не существует");
}

bool IsTriangleExist(int a, int b, int c);
{
    bool isExist = false; // Треугольник может существовать
    if (a < b + c && b < a + c && c < a + b)
    {
        isExist = true; // Такой треугольник не существует
    }
    return isExist;
}

if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine("Такой треугольник может существовать");
}
else
{
    Console.WriteLine("Треугольник с заданными сторонами не существует ");
}
