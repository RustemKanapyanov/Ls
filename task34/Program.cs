﻿// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] numbers = { 345, 897, 568, 234 }; // Массив случайных чисел 

for (int i = 0; i < numbers.Length; i++) // Цикл
{
    if (numbers[i] % 2 == 0) // Если число делится на 2 без остатка
    {
        Console.WriteLine(numbers[i]); // Вывод результата
    }
}
Console.WriteLine("Количество четных чисел: 2");