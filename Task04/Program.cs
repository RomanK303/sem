﻿// See https://aka.ms/new-console-template for more information
// Напишите программу, которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите три числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int Max = num1;
if (num1 < num2) Max = num2;
if (num2 < num3) Max = num3;
Console.WriteLine($"максимальное число : {Max}");



// int [] num = Convert.ToInt32(Console.ReadLine());
// int size = 3;
// int index =0;
// int max = numbers [0];
// while (index<size)
// {
//      if (numbers[index]>max);
//      }

// Console.ReadKey();
