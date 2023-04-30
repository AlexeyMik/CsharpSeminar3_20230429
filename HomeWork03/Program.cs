//Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int ReadInt(string text) //проглатывает в стринг число, вводимое с консоли, возвращает целочисленное значение 
{
    System.Console.Write(text);
    //System.Console.WriteLine($" Input string= {Console.ReadLine()}");
    //System.Console.Write("Confirm input ");
    return Convert.ToInt32(Console.ReadLine());
}
int nchangeorder(int isourse)
{
    int i = isourse;
    int j = i % 10;
    while (i > 10)
    {
        i = i / 10;
        j = j * 10 + (i % 10);
        //System.Console.WriteLine($" i= {i}   j={j}");
    }
    return j;
}
int num = ReadInt("Введите целое полож число: ");
if (num < 10000 || num > 99999)
{
    System.Console.WriteLine($"Warning: Введенное число не является пятизначным");
}
int j = nchangeorder(num);
System.Console.WriteLine($"        Конвертированное = {nchangeorder(num)}");
if (j == num)
{
    System.Console.WriteLine($" Да: число {num} является палиандром");
}
else
{
    System.Console.WriteLine($" Нет: число {num} не является палиандром");
}

