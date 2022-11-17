// Программа на входе число, выдача его квадрата

//int number = new Random().Next(0, 10);
//int sqr = number * number;
//Console.WriteLine(number + " " + sqr);

//int number1 = Convert.ToInt32(Console.ReadLine());
//int sqr1 = number1 * number1;
//Console.WriteLine(number1 + " " + sqr1);

//Console.WriteLine("Enter a number: ");
//string? input = Console.ReadLine();
//int number2 = Convert.ToInt32(input);
//int sqr2 = number2 * number2;
//Console.WriteLine(number2 + " " + sqr2);


// День недели по номеру дня

//int DayNumber = new Random().Next(1, 7);  мой вариант
//Console.WriteLine (DayNumber);


int dayNumber = 0;

bool isCorretInput = false;
while(!isCorretInput)
{
    Console.Write("Enter number: ");
    string? input = Console.ReadLine();
    dayNumber = Convert.ToInt32(input);
    if(dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("Incorrect number, enter another one: ");
    }
    else
    {
        isCorretInput = true;
    }

}


if(dayNumber == 1)
{
    Console.WriteLine("Monday");
}

if(dayNumber == 2)
{
    Console.WriteLine("Tuesday");
}

if(dayNumber == 3)
{
    Console.WriteLine("Wensday");
}

if(dayNumber == 4)
{
    Console.WriteLine("Thursday");
}

if(dayNumber == 5)
{
    Console.WriteLine("Friday");
}

if(dayNumber == 6)
{
    Console.WriteLine("Saturday");
}

if(dayNumber == 7)
{
    Console.WriteLine("Sunday");
}
   
else
{
    Console.WriteLine("Have a nice day!");
}

//Вариант преподавателя

Console.Write("Enter a number: ");
string inp = Console.ReadLine();
int Dnumber = Convert.ToInt32(inp);

if(Dnumber == 1)
{
    Console.WriteLine("Monday");
}
else if(Dnumber == 2)
{
    Console.WriteLine("Tuesday");
}
else if(Dnumber == 3)
{
    Console.WriteLine("Wensday");
}

//...

else
{
    Console.WriteLine("Have a nice day!");
}

//Prog for entered numbers to check if one is a*a (another)

Console.Write("Enter the numberOne: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the numberTwo: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int sqrTwo = numberTwo * numberTwo;

if(numberOne == sqrTwo)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}