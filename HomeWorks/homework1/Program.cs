int firstA = 5;
int firstB = 7;

if (firstA > firstB)
{
    Console.Write("Max = ");
    Console.WriteLine(firstA);

    Console.Write("Min = ");
    Console.WriteLine(firstB);
}
else
{
    Console.Write("Max = ");
    Console.WriteLine(firstB);

    Console.Write("Min = ");
    Console.WriteLine(firstA);
}

int secondA = 2;
int secondB = 10;

if (secondA > secondB)
{
    Console.WriteLine("Max = " + secondA);
    Console.WriteLine("Min = " + secondB);
}
else
{
    Console.WriteLine("Max = " + secondB);
    Console.WriteLine("Min = " + secondA);
}

int thirdA = -9;
int thirdB = -3;
int max;
int min;

if (thirdA > thirdB)
{
    max = thirdA;
    min = thirdB;
}
else
{
    max = thirdB;
    min = thirdA;
}

Console.WriteLine("Большее число: " + max);
Console.WriteLine("Меньшее число: " + min);
