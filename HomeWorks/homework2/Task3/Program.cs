/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите номер дня недели.");
int day = int.Parse(Console.ReadLine()!);

if (day < 8 && day > 0)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Выходной!");
    }
    else
    {
        Console.WriteLine("Рабочий день...");
    }
}
else
{
    Console.WriteLine("Введите номер дня недели (от 1 до 7)");
}
