﻿// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;
int result = 0;

while (index <= N)
{
    Console.Write(index);
    result = index * index;
    index++;
    Console.WriteLine($" {result,4}");
}

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while ( i <= num)
// {
// Console.WriteLine($"{i} | {i*i}");
// i++;
// }
