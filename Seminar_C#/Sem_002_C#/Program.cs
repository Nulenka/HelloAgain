Console.WriteLine("Напишите прогу, вход два числа, вывод - кратно ли второе первому, если нет - вывод остатка от деления. 5, 34 - 4; 4, 16");

//Console.WriteLine("Enter the 1st number");
//int FirstNumber = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the 2nd number");
//int SecondNumber = Convert.ToInt32(Console.ReadLine());

int FirstNumber = ReadInt("Enter the 1st number: ");
int SecondNumber = ReadInt("Enter the 2nd number: ");

int reminder = SecondNumber % FirstNumber;

if(reminder == 0)
{
    Console.WriteLine("Aliquot");
}
else
{
    Console.WriteLine($"Not aliquot, {reminder}");
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(" ");

Console.WriteLine("Напишите прогу, вход число, вывод - кратно ли одновременно 7 и 23. 161 - да");
Console.WriteLine("Enter a number");
int a = Convert.ToInt32(Console.ReadLine());
int b = 7;
int c = 23;

int reminderB = a % b;
int reminderC = a % c;

if(reminderB == 0 && reminderC == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
Console.WriteLine(" ");

//int number = ReadInt("Enter 1 number: ");
//int 1Divider = 7;
//int 2Divider = 23;
//if(IsMultiple(number, 1Divider) && IsMulpitple(number, 2Divider))
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//      Console.WriteLine("No");
//}
//bool IsMultiple(int first, int second)
//{
//    return first % seond == 0;
//}
//int ReadInt(string message)
//{
//    Console.WriteLine(message);
//    return Convert.ToInt32(Console.ReadLine());
//}

Console.WriteLine("Прогу, вход - два числа и проверяет, явл ли одно число квадратом другого");

int FNumber = IntRead("Enter the 1st number: ");
int SNumber = IntRead("Enter the 2nd number: ");

if(FNumber == SNumber * SNumber || SNumber == FNumber * FNumber)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
int IntRead(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(" ");

//int IntRead(string message)
//{
//    Console.Write(message);
//    return Convert.ToInt32(Console.ReadLine());
//}
//int FNumber = IntRead("Enter the 1st number: ");
//int SNumber = IntRead("Enter the 2nd number: ");
//
//if(FNumber == Sqr(SNumber) || SNumber == Sqr(FNumber))
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}
//int Sqr(in number)
//{
//    return number * number;
//}