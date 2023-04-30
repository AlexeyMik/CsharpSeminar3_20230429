//Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//
//A (3,6,8); B (2,1,-7), -> 15.84
//
//A (7,-5, 0); B (1,-1,9) -> 11.53 
int ReadInt(string text) //проглатывает в стринг число, вводимое с консоли, возвращает целочисленное значение 
{
    System.Console.Write(text);
       return Convert.ToInt32(Console.ReadLine());
}
double distance(int[] coords1, int[] coords2) 
// вычисляет расстояние между точками в 3D, координаты которых заданы в массивах целыми значениями
{
double dist=0;
for (int i=0; i<=2; i++)
{dist=dist+Math.Pow(coords1[i]-coords2[i], 2);
}
return Math.Sqrt(dist);
}

int[] coordsA = new int[3];
int[] coordsB = new int[3];
System.Console.WriteLine("Для точки А введите значения трех координат");
for (int i=0; i<=2; i++)
{
    coordsA[i]=ReadInt("введите координату "+Convert.ToString(i+1)+": ");
}
System.Console.WriteLine("Для точки B введите значения трех координат");
for (int i=0; i<=2; i++)
{
    coordsB[i]=ReadInt("введите координату "+Convert.ToString(i+1)+": ");
    //System.Console.WriteLine(coordsB[i]);
}

double dist =distance(coordsA,coordsB);
System.Console.WriteLine($"Distance= {Math.Round(dist, 2)}");
