// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();

Console.WriteLine("Чтобы возвести число А в натуральную степень В:");
Console.Write("1. Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("2. Введите целую степень В: ");
int b = Convert.ToInt32(Console.ReadLine());

int Degree(int number, int degree)
{
    int result = 1;
    if (degree > 0)
    {
        for (int i = 1; i <= degree; i++)
        {
            result = result * number;
        }
    }
    else
    {
        for (int i = 1; i <= (-1 * degree); i++)
        {
            result = result * number;
        }
        result = 1 / result;
    }
    return result;
}
int result = Degree(a, b);
Console.Write($"Число {a} в степень {b} = {result}");

