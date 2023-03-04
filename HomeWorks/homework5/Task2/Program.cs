/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Clear();

int[] getArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
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

int[] Array = getArray(length, minValue, maxValue);
Console.WriteLine(String.Join(", ", Array));

int getUnevenPos(int[] Array)
{
    int result = 0;
    for (int i = 1; i < Array.Length; i += 2)
    {
        result = result + Array[i];
    }
    return result;
}

int UnevenPosSum = getUnevenPos(Array);
Console.WriteLine($"Сумма чисал, стоящих на нечётных позициях данного массива равна {UnevenPosSum}");