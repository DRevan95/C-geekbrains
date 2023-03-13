/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] getArray(int row, int col, int minValue, int maxValue)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int giveSumOfRow(int[,] array, int row)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        result += array[row, i];
    }
    return result;
}

int foundMinSumOfRow(int[] array)
{
    int result = array[0];
    int numOfRow = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < result)
        {
            result = array[i];
            numOfRow = i + 1;
        }
    }
    return numOfRow;

}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array2D = getArray(row, col, 1, 9);
printArray(array2D);
int[] sumOfRowArray = new int[row];

for (int i = 0; i < row; i++)
{
    int sum = giveSumOfRow(array2D, i);
    sumOfRowArray[i] = sum;
}

Console.WriteLine($"{String.Join(", ", sumOfRowArray)}");
int rowOfMinSum = foundMinSumOfRow(sumOfRowArray);
Console.WriteLine($"Строка с наименьшей суммой: {rowOfMinSum}");


