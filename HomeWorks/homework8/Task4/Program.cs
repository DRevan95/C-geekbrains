/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int[,,] getArray(int x, int y, int z, int minValue, int maxValue)
{
    int[,,] result = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return result;
}

void printArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}\t {(i, j, k)}");
            }
        }
        Console.WriteLine();
    }
}

Console.Clear();

Console.Write("Введите x: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Введите z: ");
int z = int.Parse(Console.ReadLine()!);
int[,,] array3D = getArray(x, y, z, 1, 9);
printArray(array3D);
Console.WriteLine();
