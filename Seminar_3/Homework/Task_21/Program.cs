// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53

Console.Write("Введите координаты точки A (x): ");
int coordinateAx = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки A (y): ");
int coordinateAy = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки A (z): ");
int coordinateAz = int.Parse(Console.ReadLine());

Console.Write("Введите координаты точки B (x): ");
int coordinateBx = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки B (y): ");
int coordinateBy = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки B (z): ");
int coordinateBz = int.Parse(Console.ReadLine());

double FirstT = GetCalculateTheDistance3D(coordinateAx, coordinateAy, coordinateAz, 
coordinateBx, coordinateBy, coordinateBz);
Console.WriteLine(FirstT);

double GetCalculateTheDistance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double length = Math.Sqrt(Math.Pow((x2 - x1), 2) +
    Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return length;
}