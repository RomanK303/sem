// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.WriteLine("Введите номер координатной четверти: ");
int x = Convert.ToInt32(Console.ReadLine());

string Quarter(int xc) // формальные переменные
{
    if (xc == 1) return "X>0, Y>0";
    if (xc == 2) return "X<0, Y>0";
    if (xc ==3) return "X<0, Y<0";
    if (xc ==4) return "X>0, Y<0";
return "Ошибка ввода координат";
}
string result = Quarter (x); //фактические переменные в методе
Console.WriteLine(result);