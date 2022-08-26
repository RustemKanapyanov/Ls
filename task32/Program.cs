// Задача 32: Напишите программу замена элементов массива:
//  положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] arr = FillArrayWithRandomNumbers(10, -10, 10);
Console.WriteLine((string.Join(", ", arr))); // Выводим результирующий массив

SwapSingofArrayElements(arr); // Вызов метода void

// Метод возвращает массив на size элементов 
int[] FillArrayWithRandomNumbers(int size, int leftSize, int rightSize)
{
    int[] array = new int[size];

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(leftSize, rightSize + 1);
    }
    return array;
}

// Метод Замены положительных элементы на отрицательные и обратно
// с существующим Массивом
void SwapSingofArrayElements(int[] array) // Передаем массив по ссылке
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
        // array[i] = array[i] * -1;
    }
}