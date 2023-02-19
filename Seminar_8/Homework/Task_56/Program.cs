// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка
using Common;

try
{
    int m = ReadInt("Введите m");
    int n = ReadInt("Введите n");
    int[,] array = Create2DArray(m, n);
    Print2DArray(array);
    int[] result = FindMinSumRow(array);
    FindTheMotherFucker(result);
    ArrayCommon.PrintArray(result);
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
            array[i, j] = random.Next(-10, 20);
        }
    }

    return array;
}

int[] FindMinSumRow(int[,] array)
{
    int[] resultArray = new int[array.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        resultArray[i] = sum;
        sum = 0;
    }
    return resultArray;
}

void FindTheMotherFucker(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
            minIndex = i;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minIndex + 1} строка");
}

int ReadInt(string title)
{
    Console.WriteLine(title);
    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return (number);
    }

    throw new Exception("Введены не корректные символы");
}




