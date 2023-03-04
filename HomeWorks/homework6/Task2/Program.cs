/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();
int line1 = 1;
int line2 = 2;

int GetNum(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

double[] getArray(int lineNum)
{
    double[] arrayLine = new double[2];
    arrayLine[0] = GetNum($"Введите k для {lineNum} прямой");
    arrayLine[1] = GetNum($"Введите b для {lineNum} прямой");

    return arrayLine;
}
double[] KB1 = getArray(line1);
double[] KB2 = getArray(line2);
Console.WriteLine("[ " + String.Join(", ", KB1) + " ]");
Console.WriteLine("[ " + String.Join(", ", KB2) + " ]");

if (ValidateLines(KB1, KB2))
{
    double[] coords = findCoords(KB1, KB2);
    Console.Write($"Точка пересечения уравнений: y = {KB1[0]} * x + {KB1[1]} и y = {KB2[0]} * x + {KB2[1]} ");
    Console.WriteLine($" имеет координаты: ({coords[0]}, {coords[1]})");
}

double[] findCoords(double[] arrayNum1, double[] arrayNum2)
{
    double[] coords = new double[2];
    coords[0] = (KB1[0] - KB2[0]) / (KB2[1] - KB1[1]);
    coords[1] = KB1[0] * coords[0] + KB1[1];
    return coords;
}

bool ValidateLines(double[] arrayNum1, double[] arrayNum2)
{
    if (arrayNum1[0] == arrayNum2[0] && arrayNum1[1] == arrayNum2[1])
    {
        Console.WriteLine("Прямые совпадают");
        return false;
    }
    else if (arrayNum1[0] == arrayNum2[0] || arrayNum1[1] == arrayNum2[1])
    {
        Console.WriteLine("Прямые параллельны");
        return false;
    }
    else
    {
        return true;
    }


}
