// Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int number = int.Parse(Console.ReadLine());
int[,] array = CreateSpiralArray(number);
Print2DArray(array);



int[,] CreateSpiralArray(int number)
{
    int[,] array = new int[number, number];
    int lastNumber = 0;
    for (int k = 0; k < GetCountOfSpirals(number); k++)
    {
        for (int i = 0 + k; i < 1 + k; i++)
        {
            for (int j = 0 + k; j < array.GetLength(1) - k; j++)
            {
                array[i, j] = lastNumber + 1;
                lastNumber = array[i, j];
            }
        }
        for (int i = array.GetLength(1) - 1 - k; i < array.GetLength(1) - k; i++)
        {
            for (int j = 1 + k; j < array.GetLength(0) - k; j++)
            {
                array[j, i] = lastNumber + 1;
                lastNumber = array[j, i];
            }
        }
        for (int i = array.GetLength(0) - 1 - k; i < array.GetLength(0) - k; i++)
        {
            for (int j = array.GetLength(1) - 2 - k; j >= 0 + k; j--)
            {
                array[i, j] = lastNumber + 1;
                lastNumber = array[i, j];
            }
        }
        for (int j = 0 + k; j < 1 + k; j++)
        {
            for (int i = array.GetLength(0) - 2 - k; i >= 1 + k; i--)
            {
                array[i, j] = lastNumber + 1;
                lastNumber = array[i, j];
            }
        }
    }
    return array;
}

int GetCountOfSpirals(int number)
{
    int count = 0;
    if(number % 2 == 1)
    {
        count = number / 2 + 1;
    }
    else
    {
        count = number / 2;
    }
    return count;
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

