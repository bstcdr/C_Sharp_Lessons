using System.Runtime.InteropServices;
// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет

try
{
    int m = ReadIntMandN("Введите m");
    int n = ReadIntMandN("Введите n");
    Console.WriteLine("Введите строку");
    int row = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите столбец");
    int column = int.Parse(Console.ReadLine());
    int[,] array = Create2DArray(m, n);
    Print2DArray(array);
    Console.WriteLine($"Значение вашего элемента: {FindElementOfMassive(array, row, column)}");
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-100, 100);
        }
    }

    return array;
}

int FindElementOfMassive(int[,] array, int row, int column)
{
    int result = 0;
    if (row < array.GetLength(0) | column < array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (row == i)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (column == j) result = array[i, j];
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
return result;
}

int ReadIntMandN(string title)
{
    Console.WriteLine(title);
    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return (number);
    }

    throw new Exception("Введены не корректные символы");
}

int ReadIntPositionOfMassive(string title)
{
    Console.WriteLine(title);
    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return (number);
    }

    throw new Exception("Введены не корректные символы");
}
