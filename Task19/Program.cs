// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 10000 || num > 99999)
{
    Console.WriteLine("Введенное число не пятизначное");
    return;
}

int[] array = new int[5];
int i = 0;
while (i <= 4)
{
    array[i] = num % 10;
    num = (num - array[i]) / 10;
    i++;
}
if (array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine("Введенное число является палиндромом");
}
else
{
    Console.WriteLine("Введенное число не является палиндромом");
}
