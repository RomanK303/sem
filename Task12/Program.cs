// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

var rnd = new Random();
int num1 = rnd.Next(0, 100);
int num2 = rnd.Next(0, 100);

string result = num1%num2 == 0 ? $"{num1} кратно {num2}" : $"{num1} не кратно {num2} остаток {num1%num2}";
Console.WriteLine(result);



// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// // if (a % b == 0)
// // {
// // Console.WriteLine($"Число {a} кратно числу {b}");
// // }
// // else
// // {
// // int num = a % b;
// // Console.WriteLine($"Число {a} не кратно числу {b}, остаток {num}");
// // }

// string result = a % b == 0 ? $"Число {a} кратно числу {b}" : $"Число {a} не кратно числу {b}, остаток {a % b}";
// Console.WriteLine(result);