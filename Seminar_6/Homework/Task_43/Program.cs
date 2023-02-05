// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

Console.WriteLine("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine());

double[] FindCoordinates(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    if (k1 != k2)
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
    }
    double[] array = new double[] { x, y };
    return array;
}

double[] array = FindCoordinates(b1, k1, b2, k2);
PrintArray(array);

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}


