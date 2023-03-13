/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

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

int[] TransformRowToArray(int[,] array, int row)
{
    int[] rowArray = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowArray[j] = array[row, j];
        }

    }
    return rowArray;
}

void SortArray(int[] array1D)
{
    for (int i = 0; i < array1D.Length - 1; i++)
    {
        for (int j = i + 1; j < array1D.Length; j++)
        {
            if (array1D[i] < array1D[j])
            {
                int temp = array1D[i];
                array1D[i] = array1D[j];
                array1D[j] = temp;
            }
        }
    }
}

void TransformArrayToRow2DArray(int[,] array2D, int[] array1D, int columns)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[columns, j] = array1D[j];
        }
    }
}

Console.Clear();

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array2D = getArray(row, col, 1, 9);
printArray(array2D);
Console.WriteLine();

for (int i = 0; i < row; i++)
{
    int[] array1D = TransformRowToArray(array2D, i);
    Console.WriteLine($"{String.Join(", ", array1D)}");
    SortArray(array1D);
    Console.WriteLine($"{String.Join(", ", array1D)}");
    Console.WriteLine();
    TransformArrayToRow2DArray(array2D, array1D, i);
}
printArray(array2D);






