/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int expo(int A, int B)
{
    int N = Convert.ToInt32(Math.Pow(A, B));
    return N;
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("В какую степень возвести чило? ");
int extent = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {num} в степени {extent} равно {expo(num, extent)}");



