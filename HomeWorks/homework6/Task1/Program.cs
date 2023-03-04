/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.Clear();

int GetNum(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int[] getArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = GetNum($"Введите {i + 1}-й элемент массива");
    }
    return array;
}

int countPositive(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el > 0)
        {
            count++;
        }
    }
    return count;
}

int length = GetNum("Сколько элементов будет в массиве? ");
int[] Array = getArray(length);
Console.WriteLine("[ " + String.Join(", ", Array) + " ]");
int positiveNumbers = countPositive(Array);
Console.WriteLine($"Вы ввели {positiveNumbers} положительных чисел");