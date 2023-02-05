// Задача №21.Работа в группах
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 2D пространстве.
// ● A (3,6); B(2, 1)-> 5,09
// ● A(7, -5); B(1, -1)-> 7,21

// Console.Write("Введите координаты точки A (x): ");
// double coordinateAx = double.Parse(Console.ReadLine());
// Console.Write("Введите координаты точки A (y): ");
// double coordinateAy = double.Parse(Console.ReadLine());

// Console.Write("Введите координаты точки B (x): ");
// double coordinateBx = double.Parse(Console.ReadLine());
// Console.Write("Введите координаты точки B (y): ");
// double coordinateBy = double.Parse(Console.ReadLine());

// double length = Math.Sqrt(Math.Pow((coordinateBx - coordinateAx), 2) + 
// Math.Pow((coordinateAy - coordinateBy), 2));

// Console.WriteLine(length);

Console.Write("Введите координаты точки A (x): ");
int coordinateAx = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки A (y): ");
int coordinateAy = int.Parse(Console.ReadLine());

Console.Write("Введите координаты точки B (x): ");
int coordinateBx = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки B (y): ");
int coordinateBy = int.Parse(Console.ReadLine());

double FirstT = GetCalculateTheDistance(coordinateAx, coordinateAy, coordinateBx, coordinateBy);
Console.WriteLine(FirstT);

double GetCalculateTheDistance(int x1, int y1, int x2, int y2)
{
    double length = Math.Sqrt(Math.Pow((x1 - x2), 2) +
    Math.Pow((y1 - y2), 2));
    return length;
}