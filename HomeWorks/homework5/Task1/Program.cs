/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
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
int[] Array = getArray(length, 100, 999);
Console.WriteLine(String.Join(", ", Array)); //Вывод массива в консоль без прописывания функции.

int getEvenNum()
{
    int result = 0;
    foreach (int el in Array) //перебор каждого элемента массива
    {
        if (el % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

int evenNumbers = getEvenNum();

Console.WriteLine($"В данном массиве {evenNumbers} чётных чисел");

