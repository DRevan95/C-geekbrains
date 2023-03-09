/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] getArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
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
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void getNumber(int index, int[,] array)
{
    int x = index / 10;
    int y = index % 10;
    int num = array[x, y];

    if (x > array.GetLength(0) || x < 0 || y > array.GetLength(0) || y < 0)
    {
        Console.Write("В массиве нет такого числа");
    }
    else
    {
        Console.Write($"На позиции {index} находится число {num}");
    }
}


Console.Clear();

Console.Write("Введите m: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = getArray(row, col, -5, 5);
printArray(array2D);

Console.Write("Введите индекс числа: ");
int indexNum = int.Parse(Console.ReadLine()!);
getNumber(indexNum, array2D);
