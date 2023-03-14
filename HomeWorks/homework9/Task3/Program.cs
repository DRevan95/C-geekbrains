/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3->A(m, n) = 9
m = 3, n = 2->A(m, n) = 29
 */

Console.Clear();

int getAkkermanF(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return getAkkermanF(m - 1, 1);
    return getAkkermanF(m - 1, getAkkermanF(m, n - 1));
}

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(getAkkermanF(m, n));