// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();

double[] getArray(int size, int min, int max)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1) + Math.Round(new Random().NextDouble(), 4);
        //array[i] = Math.Round(array[i], 2);
    }
    return array;
}



Console.Write("Сколько элементов будет в массиве? ");
int length = int.Parse(Console.ReadLine()!);
int minValue = 1;
int maxValue = 0;
while (minValue > maxValue)
{
    Console.Write("Задайте минимальное число массива: ");
    minValue = int.Parse(Console.ReadLine()!);
    Console.Write("Задайте максимальное число массива: ");
    maxValue = int.Parse(Console.ReadLine()!);
}
double[] Array = getArray(length, minValue, maxValue);
Console.WriteLine($"{String.Join(", ", Array)}");

double getMaxNum(double[] array)
{
    double result = array[0];
    foreach (double el in Array)
    {
        if (el > result)
        {
            result = el;
        }
    }
    return result;
}

double getMinNum(double[] array)
{
    double result = array[0];
    foreach (double el in Array)
    {
        if (el < result)
        {
            result = el;
        }
    }
    return result;
}
double maxNum = getMaxNum(Array);
double minNum = getMinNum(Array);

Console.WriteLine($"Разница между минимальным числом массива {minNum} и максимальным числом массива {maxNum} равна {maxNum - minNum}");




