// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите три числа");
int storonaA = int.Parse(Console.ReadLine());
int storonaB = int.Parse(Console.ReadLine());
int storonaC = int.Parse(Console.ReadLine());

Console.WriteLine(GetProveThatItTriangle(storonaA, storonaB, storonaC));

bool GetProveThatItTriangle(int A, int B, int C)
{
    if(A < B + C & B < A + C & C < A + B) 
    {
        return true;
    }
    return false;
}
