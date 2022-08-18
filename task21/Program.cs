// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] dot1 = new int[3];
int[] dot2 = new int[3];
Console.Clear();
Console.WriteLine("Давайте определим расстояние между точками в пространстве по их координатам ");
Console.WriteLine("Введите координаты первой точки: ");

for (int i = 0; i <3; i++)
    {
        Console.WriteLine("Введите координату {0:G}\n",i+1);
        dot1[i]=Convert.ToInt32(Console.ReadLine()); 
    }
Console.Clear();
Console.WriteLine("Введите координаты второй точки:");

for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Введите координату {0:G}\n",i+1);
        dot1[i]=Convert.ToInt32(Console.ReadLine()); 
    }
double[] pow2= new double[3];
for (int i = 0; i <3; i++)
    {
        pow2[i] = Math.Pow( Convert.ToDouble(dot1[i] - dot2[i]),2);
    }
Console.Clear();
Console.WriteLine("Расстояние между точками составляет:");
Console.WriteLine("{0:0.00}",Math.Sqrt(pow2[0] + pow2[1] + pow2[2]));
