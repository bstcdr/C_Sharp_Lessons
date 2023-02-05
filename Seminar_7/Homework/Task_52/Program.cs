// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
using  Common;


try
{
    int m = ReadIntMandN("Введите m");
    int n = ReadIntMandN("Введите n");

    int[,] array = Create2DArray(m, n);
    Print2DArray(array);

    double[] arrayResult = GetAverageArifmeticOfColumn2DMassive(array);
    Console.Write("Среднее арифметическое каждого столбца: ");
    ArrayCommon.PrintArray(arrayResult);
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
            array[i, j] = random.Next(0, 10);
        }
    }

    return array;
}


double[] GetAverageArifmeticOfColumn2DMassive(int[,] array)
{
    double sum = 0;
    double average = 0;
    double[] arrayResult = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
        }
        average = sum / array.GetLength(0);
        arrayResult[i] = average;
        sum = 0;
        average = 0;
    }
    return arrayResult;
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





