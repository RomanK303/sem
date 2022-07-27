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

// Console.WriteLine("Введите номер четверти от 1 до 4");
// int x = Convert.ToInt32(Console.ReadLine());
// switch (x)
// {
// case 1: Console.WriteLine("x > 0 и y > 0"); break;
// case 2: Console.WriteLine("x < 0 и y > 0"); break;
// case 3: Console.WriteLine("x < 0 и y < 0"); break;
// case 4: Console.WriteLine("x > 0 и y < 0"); break;
// default: Console.WriteLine("Нет такой четверти"); break;
// }


// string Quarter(int x, int y)
// {
// switch ((x, y))
// {
// case ( > 0, > 0):
// return "Первая четверь";
// case ( < 0, > 0):
// return "Вторая четверь";
// case ( < 0, < 0):
// return "Третья четверь";
// case ( > 0, < 0):
// return "Четвёртая четверь";
// default:
// return "Введены некорректные координаты";
// }
// }