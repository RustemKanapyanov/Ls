// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
// Выводить сообщение "да" или "нет" ТОЛЬКО ОДИН РАЗ

int[] FillArrayWithRandomNumbers(int size, int leftRange, int righRange)
{
    int[] array = new int[size];

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(leftRange, righRange + 1);
    }
    return array;
}
int[] arr = FillArrayWithRandomNumbers(10, -10, 10);
Console.WriteLine(string.Join(", ", arr));


Console.WriteLine("Какое число вы хотите найти в массиве? ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = IsNumberInArray(arr, number);
if (result == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


bool IsNumberInArray(int[] arr, int findNumber)
{
    bool flag = false; //Если элемента в массиве нет, то - false
                       //Иначе - true

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == findNumber)
        {
            flag = true; //Исходный элемент найден
            break;
        }
    }
    return flag;
}