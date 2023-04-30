// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num= Math.Abs(ReadInt("Введите целое полож число: "));

for (int i=1; i<=num; i++)
{
    System.Console.Write($"  {Math.Pow(i,2)}");
}