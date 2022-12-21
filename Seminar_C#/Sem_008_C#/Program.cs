Console.WriteLine("Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.");
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);

int firstIndex = 0;
int secondIndex = numbers.GetLength(0) - 1;

for(int i = 0; i < numbers.GetLength(1); i++)
{
    int temp = numbers[firstIndex, i];
    numbers[firstIndex, i] = numbers[secondIndex, i];
    numbers[secondIndex, i] = temp;
}
WriteMatrix(numbers);

void FillMatrixRandomNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void WriteMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine("Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.");
int rows1 = ReadInt1("Введите количество строк: ");
int columns1 = ReadInt1("Введите количество столбцов: ");
int[,] numbers1 = new int[rows1, columns1];
int[,] revertNumbers = new int[numbers1.GetLength(1), numbers1.GetLength(0)];
FillMatrixRandomNumbers1(numbers1);
WriteMatrix1(numbers1);

for(int i1 = 0; i1 < revertNumbers.GetLength(0); i1++)
{
    for(int j1 = 0; j1 < revertNumbers.GetLength(1); j1++)
    {
        revertNumbers[i1, j1] = numbers1[j1, i1];
    }
}

WriteMatrix1(revertNumbers);

void FillMatrixRandomNumbers1(int[,] array1)
{
    for(int i1 = 0; i1 < array1.GetLength(0); i1++)
    {
        for(int j1 = 0; j1 < array1.GetLength(1); j1++)
        {
            array1[i1, j1] = new Random().Next(1, 10);
        }
    }
}
void WriteMatrix1(int[,] array1)
{
    for(int i1 = 0; i1 < array1.GetLength(0); i1++)
    {
        for(int j1 = 0; j1 < array1.GetLength(1); j1++)
        {
            Console.Write(array1[i1, j1] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt1(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// относительно диагонали, по идексам
int rows2 = ReadInt2("Введите количество строк: ");
int columns2 = ReadInt2("Введите количество столбцов: ");

if(rows2 != columns2)
{
    Console.WriteLine("Операция невозможна");
    return;
}
int[,] numbers2 = new int[rows2, columns2];
FillMatrixRandomNumbers2(numbers2);
WriteMatrix2(numbers2);

for(int i2 = 0; i2 < numbers2.GetLength(0); i2++)
{
    for(int j2 = i2; j2 < numbers2.GetLength(1); j2++)
    {
        int temp2 = numbers2[i2, j2];
        numbers2[i2, j2] = numbers2[j2, i2];
        numbers2[j2, i2] = temp2;
    }
}
WriteMatrix2(numbers2);

void FillMatrixRandomNumbers2(int[,] array2)
{
    for(int i2 = 0; i2 < array2.GetLength(0); i2++)
    {
        for(int j2 = 0; j2 < array2.GetLength(1); j2++)
        {
            array2[i2, j2] = new Random().Next(1, 10);
        }
    }
}
void WriteMatrix2(int[,] array2)
{
    for(int i2 = 0; i2 < array2.GetLength(0); i2++)
    {
        for(int j2 = 0; j2 < array2.GetLength(1); j2++)
        {
            Console.Write(array2[i2, j2] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt2(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//по диагонали разворот, верний правы угол -> низ лево:
int rows3 = ReadInt3("Введите количество строк: ");
int columns3 = ReadInt3("Введите количество столбцов: ");

if(rows3 != columns3)
{
    Console.WriteLine("Операция невозможна");
    return;
}

int[,] numbers3 = new int[rows3, columns3];
FillMatrixRandomNumbers3(numbers3);
WriteMatrix3(numbers3);

for(int i3 = 0; i3 < numbers3.GetLength(0); i3++)
{
    for(int j3 = 0; j3 < numbers3.GetLength(1); j3++)
    {
        if(i3 == j3)
        break;
        int temp3 = numbers3[i3, j3];
        numbers3[i3, j3] = numbers3[j3, i3];
        numbers3[j3, i3] = temp3;
    }
}
WriteMatrix3(numbers3);

void FillMatrixRandomNumbers3(int[,] array3)
{
    for(int i3 = 0; i3 < array3.GetLength(0); i3++)
    {
        for(int j3 = 0; j3 < array3.GetLength(1); j3++)
        {
            array3[i3, j3] = new Random().Next(1, 10);
        }
    }
}

void WriteMatrix3(int[,] array3)
{
    for(int i3 = 0; i3 < array3.GetLength(0); i3++)
    {
        for(int j3 = 0; j3 < array3.GetLength(1); j3++)
        {
            Console.Write(array3[i3, j3] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt3(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. 1 2 3, 4 6 1, 2 1 6. Answer: 1 встречается 3 раза, 2 встречается 2 раза, 3 встречается 1 раз, 4 встречается 1 раз, 6 встречается 2 раза");
int rows4 = ReadInt4("Введите количество строк: ");
int columns4 = ReadInt4("Введите количество столбцов: ");
int[,] numbers4 = new int[rows4, columns4];
FillMatrixRandomNumbers4(numbers4);
WriteMatrix4(numbers4);
SortArray4(numbers4);
WriteMatrix4(numbers4);

int[,] dictionary = FrequencyDictionary(numbers4);
for (int i4 = 0; i4 < dictionary.GetLength(0); i4++)
{
    Console.WriteLine($"{dictionary[i4, 0]} встречается {dictionary[i4, 1]}");
}

int[,] FrequencyDictionary(int[,] matrix4)
{
    int size4 = CalculateCountNumbers(matrix4);
    int[,] dictionary = new int[size4, 2];
    int dictionaryIndex = 0;
    dictionary[dictionaryIndex, 0] = matrix4[0, 0];
    for(int i4 = 0; i4 < matrix4.GetLength(0); i4++)
    {
        for(int j4 = 0; j4 < matrix4.GetLength(1); j4++)
        {
            if (dictionary[dictionaryIndex, 0] == matrix4[i4, j4])
            dictionary[dictionaryIndex, 1]++;
            else
            {
                dictionaryIndex++;
                dictionary[dictionaryIndex, 0] = matrix4[i4, j4];
                dictionary[dictionaryIndex, 1] = 1;
            }
        }
    }
    return dictionary;
}

int CalculateCountNumbers(int[,] sortMatrix)
{
    int countNumbers4 = 1;
    int tempNumber4 = sortMatrix[0, 0];
    for(int i4 = 0; i4 < sortMatrix.GetLength(0); i4++)
    {
        for(int j4 = 0; j4 < sortMatrix.GetLength(1); j4++)
        {
            if(tempNumber4 != sortMatrix[i4, j4])
            {
                tempNumber4 = sortMatrix[i4, j4];
                countNumbers4++;
            }
        }
    }
    return countNumbers4;
}

void SortArray4(int[,] matrix4)
{
    for (int i4 = 0; i4 < matrix4.GetLength(0); i4++)
    {
        for (int j4 = 0; j4 < matrix4.GetLength(1); j4++)
        {
            for (int a4 = 0; a4 < matrix4.GetLength(0); a4++)
            {
                for (int b4 = 0; b4 < matrix4.GetLength(1); b4++)
                {
                    if (matrix4[a4, b4] < matrix4[i4, j4])
                    {
                        int temp4 = matrix4[i4, j4];
                        matrix4[i4, j4] = matrix4[a4, b4];
                        matrix4[a4, b4] = temp4;
                    }
                }
            }
        }
    }
}

void FillMatrixRandomNumbers4(int[,] array4)
{
    for(int i4 = 0; i4 < array4.GetLength(0); i4++)
    {
        for(int j4 = 0; j4 < array4.GetLength(1); j4++)
        {
            array4[i4, j4] = new Random().Next(1, 10);
        }
    }
}

void WriteMatrix4(int[,] array4)
{
    for(int i4 = 0; i4 < array4.GetLength(0); i4++)
    {
        for(int j4 = 0; j4 < array4.GetLength(1); j4++)
        {
            Console.Write(array4[i4, j4] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt4(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(" ");

Console.WriteLine("Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. Например, задан массив: 1 4 7 2, 5 9 2 3, 8 4 2 4, 5 2 6 7, Наименьший элемент - 1, на выходе получим следующий массив: 9 4 2, 2 2 6, 3 4 7");
int ReadInt8(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrixRandomNumbers8(int[,] array8)
{
    for (int i8 = 0; i8 < array8.GetLength(0); i8++)
    {
        for (int j8 = 0; j8 < array8.GetLength(1); j8++)
        {
            array8[i8, j8] = new Random().Next(0, 10);
        }
    }
}

void WriteMatrix8(int[,] array8)
{
    for (int i8 = 0; i8 < array8.GetLength(0); i8++)
    {
        for (int j8 = 0; j8 < array8.GetLength(1); j8++)
        {
            Console.Write(array8[i8, j8] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int Min8(int[,]array8)
{
    int min8 = int.MaxValue;
    for (int i8 = 0; i8 < array8.GetLength(0); i8++)
    {
        for (int j8 = 0; j8 < array8.GetLength(1); j8++)
        {
            if (array8[i8, j8] < min8)
            {
                min8 = array8[i8, j8];
            }
        }
    }
    return min8;
}

int [] Find8(int[,]array8)
{
    int b8 = Min8(array8);
    int [] m8 = new int[2];
    for (int i8 = 0; i8 < array8.GetLength(0); i8++)
    {
        for (int j8 = 0; j8 < array8.GetLength(1); j8++)
        {
            if (array8[i8, j8] == b8)
            {
                m8[0] = i8;
                m8[1] = j8;
                break;
            }
        }
    }
    return m8;
}

int [,] DeleteMas8(int [,]array8)
{
    int [] c8 = Find8(array8);
    int [,] otv = new int [array8.GetLength(0) - 1, array8.GetLength(1) - 1];
    int otvI = 0;
    int otvJ = 0;
    for (int i8 = 0; i8 < array8.GetLength(0); i8++)
    {
        if (i8 == c8[0])
            continue;

        for (int j8 = 0; j8 < array8.GetLength(1); j8++)
        {
            if(j8 == c8[1])
                continue;
            otv[otvI, otvJ] = array8[i8, j8];
            otvJ++;
        }
        otvI++;
        otvJ = 0;
    }
    return otv;
}

int rows8 = ReadInt8("Введите количество строк матрицы: ");
int columns8 = ReadInt8("Введите количество столбцов матрицы: ");
int[,] numbers8 = new int[rows8, columns8];


FillMatrixRandomNumbers8(numbers8);
WriteMatrix8(numbers8);
WriteMatrix8(DeleteMas8(numbers8));









Console.WriteLine("Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника*");

