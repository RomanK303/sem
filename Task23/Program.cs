﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
//  чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
int result = 0;

while (i <= N)
{
    Console.Write(i);
    result = i * i * i;
    i++;
    Console.WriteLine($" |  {result,4}   |");
}