Console.WriteLine("A variant of geting массив вещественных чисел");
int size = ReadInt("Введите размер массива: ");
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
WriteArray(numbers);


void FillArrayRandomNumbers(double[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().NextDouble() * 100;
}
}

void WriteArray(double[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Another variant of geting массив вещественных чисел");

int size09 = ReadInt09("Введите размер массива: ");
double[] numbers09 = new double[size09];
FillArrayRandomNumbers09(numbers09);
WriteArray09(numbers09);


void FillArrayRandomNumbers09(double[] array)
{
for(int i09 = 0; i09 < array.Length; i09++)
{
int randomNumber09 = new Random().Next(100, 1000);
array[i09] = Convert.ToDouble(randomNumber09) / 100;
}
}

void WriteArray09(double[] array)
{
for(int i09 = 0; i09 < array.Length; i09++)
{
Console.Write(array[i09] + " ");
}
Console.WriteLine();
}

int ReadInt09(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("прогу, перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.), [1 2 3 4 5] -> [5 4 3 2 1], [6 7 3 6] -> [6 3 7 6]");
int size1 = ReadInt1("Введите размер массива: ");
int[] numbers1 = new int[size1];
FillArrayRandomNumbers1(numbers1);
WriteArray1(numbers1);

for(int i1 = 0; i1 < numbers1.Length / 2; i1++)
{
int temp1 = numbers1[numbers1.Length - 1 - i1];
numbers1[numbers1.Length - 1 - i1] = numbers1[i1];
numbers1[i1] = temp1;
}
WriteArray1(numbers1);

void FillArrayRandomNumbers1(int[] array)
{
for(int i1 = 0; i1 < array.Length; i1++)
{
array[i1] = new Random().Next(1, 10);
}
}

void WriteArray1(int[] array)
{
for(int i1 = 0; i1 < array.Length; i1++)
{
Console.Write(array[i1] + " ");
}
Console.WriteLine();
}

int ReadInt1(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины. !!! Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.");
int lineA = ReadInt("Введите сторону A: ");
int lineB = ReadInt("Введите сторону B: ");
int lineC = ReadInt("Введите сторону C: ");

if(CheckSide(lineA, lineB, lineC) && CheckSide(lineB, lineA, lineC) && CheckSide(lineC, lineB, lineA))
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}

bool CheckSide(int checkSide, int a , int b)
{
return checkSide < a + b;
}

Console.WriteLine("Задача: прога для перевода десятич в двоичную систему исчисления");
int number = ReadInt("Введите десятичное число: ");
string binaryNumber = "";
int baseNumber = 2;
while(number > 0)
{
int divider = number % baseNumber;
binaryNumber = divider + binaryNumber;
number /= baseNumber;
}
Console.WriteLine(binaryNumber);

Console.WriteLine("Задача: прога для перевода десятич в двоичную систему исчисления");
int number3 = ReadInt3("Введите десятичное число: ");
int baseNumber3 = 2;
int tempNumber3 = number3;
int count3 = 0;
while(tempNumber3 > 0)
{
count3++;
tempNumber3 /= baseNumber3;
}
int[] binary3 = new int[count3];

for(int i3 = binary3.Length - 1; i3 >= 0; i3--)
{
binary3[i3] = number3 % baseNumber3;
number3 /= baseNumber3;
}

WriteArray3(binary3);

void WriteArray3(int[] array3)
{
for(int i3 = 0; i3 < array3.Length; i3++)
{
Console.Write(array3[i3] + " ");
}
Console.WriteLine();
}

int ReadInt3(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. Если N = 5 -> 0 1 1 2 3, Если N = 3 -> 0 1 1, Если N = 7 -> 0 1 1 2 3 5 8");
int count4 = ReadInt4("Введите количество членов ряда Фибоначчи: ");
int firstNumber = 0;
int secondNumber = 1;

if(count4 > 0)
Console.Write(firstNumber + " ");
if(count4 > 1)
Console.Write(secondNumber + " ");

for (int i4 = 2; i4 < count4; i4++)
{
int nextNumber = firstNumber + secondNumber;
firstNumber = secondNumber;
secondNumber = nextNumber;
Console.Write(nextNumber + " ");
}

int ReadInt4(string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(" ");

Console.WriteLine("Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. Если N = 5 -> 0 1 1 2 3, Если N = 3 -> 0 1 1, Если N = 7 -> 0 1 1 2 3 5 8");
int count5 = ReadInt5("Введите количество членов ряда Фибоначчи: ");
int[] fibonacci = new int[count5];

if(count5 > 0)
fibonacci[0] = 0;
if(count5 > 1)
fibonacci[1] = 1;

for (int i5 = 2; i5 < count5; i5++)
{
fibonacci[i5] = fibonacci[i5 - 1] + fibonacci[i5 - 2];
}
WriteArray5(fibonacci);

void WriteArray5(int[] array5)
{
for(int i5 = 0; i5 < array5.Length; i5++)
{
Console.Write(array5[i5] + " ");
}
Console.WriteLine();
}

int ReadInt5(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(" ");


Console.WriteLine("Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.");

int size6 = ReadInt6("Введите размер: ");
int[] numbers6 = new int[size6];
FillArrayRandomNumbers6(numbers6);

int[] copyNumbers6 = CopyArray6(numbers6);
WriteArray6(numbers6);
WriteArray6(copyNumbers6);

int[] CopyArray6(int[] array6)
{
int[] copyArray6 = new int[array6.Length];
for(int i6 = 0; i6 < array6.Length; i6++)
{
copyArray6[i6] = array6[i6];
}
return copyArray6;
}

void FillArrayRandomNumbers6(int[] array6)
{
for(int i6 = 0; i6 < array6.Length; i6++)
{
array6[i6] = new Random().Next(1, 10);
}
}

void WriteArray6(int[] array6)
{
for(int i6 = 0; i6 < array6.Length; i6++)
{
Console.Write(array6[i6] + " ");
}
Console.WriteLine();
}

int ReadInt6(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

