/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();

Console.Write("Введите координаты точки А (x, y, z): ");
int Ax = int.Parse(Console.ReadLine()!);
int Ay = int.Parse(Console.ReadLine()!);
int Az = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты точки B (x, y, z): ");
int Bx = int.Parse(Console.ReadLine()!);
int By = int.Parse(Console.ReadLine()!);
int Bz = int.Parse(Console.ReadLine()!);

double AB = Math.Sqrt(
    Math.Pow(Ax - Bx, 2) +
    Math.Pow(Ay - By, 2) +
    Math.Pow(Az - Bz, 2)
);

Console.WriteLine($"{AB:f2}");
