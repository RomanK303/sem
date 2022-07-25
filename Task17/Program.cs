// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.
Console.Clear();
Console.WriteLine("Введите коордиинаты точки: ");
Console.Write("X =  ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y = ");
int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("1 четверть");
// else if (x < 0 && y > 0) Console.WriteLine("2 четверть");
// else if (x < 0 && y < 0) Console.WriteLine("3 четверть");
// else if (x > 0 && y < 0) Console.WriteLine("4 четверть");
// else Console.WriteLine("Ошибка ввода координат");

string Quarter(int xc, int yc) // формальные переменные
{
    if (xc > 0 && yc > 0) return "1 четверть";
    if (xc < 0 && yc > 0) return "2 четверть";
    if (xc < 0 && yc < 0) return "3 четверть";
    if (xc > 0 && yc < 0) return "4 четверть";
return "Ошибка ввода координат";
}
string result = Quarter(x,y); //фактические переменные в методе
Console.WriteLine(result);