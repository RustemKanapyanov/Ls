// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Write("Введите число: ");
int sqare = Convert.ToInt32(Console.ReadLine());

void Sqare(int[] sqare){
  int counter = 0;
  int length = sqare.Length;
  while (counter <  length){
    sqare[counter] = Convert.ToInt32(Math.Pow(counter, 2));
    counter++;
  }
}
void PrintArr(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 
int[] arry = new int[sqare+1];
Sqare(arry);
PrintArr(arry);