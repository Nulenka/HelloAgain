Console.WriteLine("Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. Example: N = 5 -> 1, 2, 3, 4, 5. N = 6 -> 1, 2, 3, 4, 5, 6");

int number = ReadInt("Enter N: ");
Console.WriteLine(NaturealNumer(number));

int NaturealNumer(int n)
{
    if(n == 1)
        return 1;
    else
    {
        Console.Write(NaturealNumer(n - 1) + ", ");
    }
    return n;
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}


Console.WriteLine("Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. Example: N = 5 -> 1, 2, 3, 4, 5. N = 6 -> 1, 2, 3, 4, 5, 6");

int number1 = ReadInt1("Введите N: ");
NaturalNumber1(number1);

void NaturalNumber1(int n1)
{
    if(n1 == 1)
    Console.Write(n1 + ", ");
    else
    {
        NaturalNumber1(n1 - 1);
        Console.Write(n1 + ", ");
    }
}

int ReadInt1(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

Console.WriteLine("Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. M = 1; N = 5 -> 1, 2, 3, 4, 5, M = 4; N = 8 -> 4, 6, 7, 8");

int numberM = ReadInt2("Введите M: ");
int numberN = ReadInt2("Введите N: ");

if (numberM > numberN)
{
    int temp2 = numberM;
    numberM = numberN;
    numberN = temp2;
}

Console.WriteLine(NumbersMinMax2(numberM, numberN));
Console.WriteLine(NumbersMaxMin2(numberN, numberM));

int NumbersMinMax2(int m2, int n2)
{
    if (n2 == m2)
    return n2;
    else
    {
        Console.Write(NumbersMinMax2(m2, n2 - 1) + ", ");
    }
    return n2;
}

int NumbersMaxMin2(int n2, int m2)
{
    if (m2 == n2)
    return m2;
    else
    {
        Console.Write(NumbersMaxMin2(n2, m2 + 1) + ", ");
    }
    return m2;
}

int ReadInt2(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//Teacher's solution
int start3 = ReadInt3("Введите M: ");
int end3 = ReadInt3("Введите N: ");
NaturalNumber3(start3, end3);

void NaturalNumber3(int m3, int n3)
{
    if (m3 < n3)
    {
        Console.Write($"{m3}, ");
        NaturalNumber3(m3 + 1, n3);
    }
    if (m3 > n3)
    {
        Console.Write($"{m3}, ");
        NaturalNumber3(m3 - 1, n3);
    }
    if (m3 == n3)
    {
        Console.Write($"{m3} ");
    }
}
Console.WriteLine(" ");

int ReadInt3(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}


Console.WriteLine("Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму цифр. 453 -> 12, 45 -> 9");

int number4 = ReadInt4("Enter a number: ");
Console.WriteLine("Sum of figures: " + Sum4(number4));

int Sum4(int n4)
{
    if (n4 > 0)
        return n4 % 10 + Sum4(n4 / 10);

    return 0;
}
Console.WriteLine(" ");

int ReadInt4(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

Console.WriteLine("Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии. A = 3; B = 5 -> 243 (3⁵), A = 2; B = 3 -> 8");

int a = ReadInt5("Введите число: ");
int b = ReadInt5("Введите степень: ");
Console.WriteLine($"{a} в степени {b} = {Pow(a, b)}");

int Pow(int a, int pow)
{
    if(pow == 0)
        return 1;

    return a * Pow(a, pow - 1);
}

int ReadInt5(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

