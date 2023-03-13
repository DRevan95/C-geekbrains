/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] getArray(int row, int col)
{
    int[,] result = new int[row, col];
    int num = 1;
    int c = 1;
    int d = 1;
    for (int i = 0; i < row; i++)
    {
        result[0, i] = num;
        num++;
    }

    for (int j = 1; j < row; j++)
    {
        result[j, col - 1] = num;
        num++;
    }

    for (int k = col - 2; k >= 0; k--)
    {
        result[row - 1, k] = num;
        num++;
    }

    for (int y = row - 2; y > 0; y--)
    {
        result[y, 0] = num;
        num++;
    }

    while (num < row * col)
    {
        while (result[c, d + 1] == 0)
        {
            result[c, d] = num;
            num++;
            d++;
        }

        while (result[c + 1, d] == 0)
        {
            result[c, d] = num;
            num++;
            c++;
        }

        while (result[c, d - 1] == 0)
        {
            result[c, d] = num;
            num++;
            d--;
        }

        while (result[c - 1, d] == 0)
        {
            result[c, d] = num;
            num++;
            c--;
        }
    }
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if (result[i, j] == 0)
            {
                result[i, j] = num;
            }
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

Console.Clear();

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array2D = getArray(row, col);
printArray(array2D);
Console.WriteLine();
