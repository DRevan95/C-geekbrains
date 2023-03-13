/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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

int[,] multiplyOfMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
    {
        Console.Write("Умножение невозможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы!");
    }
    else
    {
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                result[i, j] = 0;

                for (int k = 0; k < firstMatrix.GetLength(1); k++)
                {
                    result[i, j] = firstMatrix[i, k] * secondMatrix[k, j];
                }
            }
        }
    }
    return result;
}



Console.Clear();

Console.Write("Количество строк первой матрицы: ");
int row1 = int.Parse(Console.ReadLine()!);
Console.Write("Количество стоблцов первой матрицы: ");
int col1 = int.Parse(Console.ReadLine()!);
int[,] matrix1 = getArray(row1, col1, -10, 10);
printArray(matrix1);
Console.WriteLine();

Console.Write("Количество строк второй матрицы: ");
int row2 = int.Parse(Console.ReadLine()!);
Console.Write("Количество стоблцов второй матрицы: ");
int col2 = int.Parse(Console.ReadLine()!);
int[,] matrix2 = getArray(row2, col2, -10, 10);
printArray(matrix2);
Console.WriteLine();

int[,] multiplyMatrix = multiplyOfMatrix(matrix1, matrix2);
printArray(multiplyMatrix);






