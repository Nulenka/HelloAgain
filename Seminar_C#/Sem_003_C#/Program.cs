Console.WriteLine("Задача: прогу, вход - координаты точки (Х, У) причем Х != 0, У != 0. Выход - номер четверти плоскости (против часовой).");
int x = ReadInt("Enter X coordinate: ");
int y = ReadInt("Enter Y coordinate: ");

//if (x != 0 && y != 0)
//{
//    Console.WriteLine("WellDone!");
//}
//else
//{
    //Console.WriteLine("Y and X cannot be zero");
//}                                            НО ЛУЧШЕ:

if (x == 0 || y == 0)
{
    Console.WriteLine("Y and X cannot be zero");
    return;
}

if (x > 0 && y > 0)
{
    Console.WriteLine("1 quarter");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("2 quarter");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("3 quarter");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("4 quarter");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(" ");

Console.WriteLine("Задача: прогу, вход - заданный номер четверти, выход - диапазон возможных координат.");
int quarter = ReadInt1("Enter a quarter number: ");

if(quarter == 1)
{
    Console.WriteLine("x > 0, y > 0");
}
else if(quarter == 2)
{
    Console.WriteLine("x < 0, y > 0");
}
else if(quarter == 3)
{
    Console.WriteLine("x < 0, y < 0");
}
else if(quarter == 4)
{
    Console.WriteLine("x < 0, y < 0");
}

else
{
    Console.WriteLine("There are only 4 quarters!");
}

switch (quarter)
{
    case 1:
        Console.WriteLine("x > 0, y > 0");
        break;
    case 2:
        Console.WriteLine("x < 0, y > 0");
        break;
    case 3:
        Console.WriteLine("x < 0, y < 0");
        break;
    case 4:
        Console.WriteLine("x > 0, y < 0");
        break;
    default:
        Console.WriteLine("There are only 4 quarters!");
        break;
}


int ReadInt1(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(" ");

Console.WriteLine("Прогу: вход - координаты двух точек, выход - расстояние между ними  в 2D.");
int aX = ReadInt2("Enter A coordinate X: ");
int aY = ReadInt2("Enter A coordinate Y: ");
int bX = ReadInt2("Enter B coordinate X: ");
int bY = ReadInt2("Enter B coordinate Y: ");

int sqrSideX = (aX - bX) * (aX - bX);
int sqrSideY = (aY - bY) * (aY - bY);
double distance = Math.Sqrt(sqrSideX + sqrSideY);
Console.WriteLine(distance);

int ReadInt2(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(" ");


Console.WriteLine("Прогу: вход - число (N), выход - таблицу квадратов чисел от 1 до N.");