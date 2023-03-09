/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

double[] getColAverage(int[,] array, int size)
{
    double[] sumColArray = new double[size];
    for (int i = 0; i < array.GetLength(1); i++) //GetLength(1) длина массива по столбцам
    {
        for (int j = 0; j < array.GetLength(0); j++) //GetLength(0) длина массива по строкам
        {
            sumColArray[i] += array[j, i];//нахождение суммы всех элементов в столбце
        }
        sumColArray[i] = sumColArray[i] / size;// среднее арифметическое одного столбца
    }
    return sumColArray;
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int min = new Random().Next(0, 10);
int max = new Random().Next(10, 100);
int[,] array2D = getArray(row, col, min, max + 1);
printArray(array2D);

double[] colSum = getColAverage(array2D, col);
Console.WriteLine($"{String.Join(", ", colSum)}");

