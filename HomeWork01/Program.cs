﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
int ReadInt(string text) //проглатывает в стринг число, вводимое с консоли, возвращает целочисленное значение 
{
    System.Console.Write(text);
    //System.Console.WriteLine($" Input string= {Console.ReadLine()}");
    //System.Console.Write("Confirm input ");
    return Convert.ToInt32(Console.ReadLine());
}

int num = ReadInt("Введите целое полож число: ");
if (num > 0)
{
    for (int i = 1; i <= num; i++)
    {
        System.Console.Write($"  {Math.Pow(i, 3)}");
    }
}
else
{
    System.Console.Write($" Input data {num} is out of range");
}