﻿
//  8: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= num; i++)
// {
//     if (i % 2 == 0) ;
// }
// Console.WriteLine($"четные числа : {i + ""}");

 
    {
        Console.Write("Write number 1: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Write number 2: ");
        int m = int.Parse(Console.ReadLine());
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadKey();
    }
