/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int GetNum(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int[] GetArray(int length, int min, int max)
{
    int[] Array = new int[length];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(min, max);
    }
    return Array;
}

void printArray(int[] Array)
{
    Console.Write("[");
    for (int i = 0; i < Array.Length - 1; i++)
    {
        Console.Write($"{Array[i]}, ");
    }
    Console.Write($"{Array[Array.Length - 1]}");
    Console.Write("]");
}

int length = GetNum("Введите длину массива:");
int min = GetNum("Введите минимальное число массива");
int max = GetNum("Введите максимальное число массива");
int[] array = GetArray(length, min, max);

printArray(array);





