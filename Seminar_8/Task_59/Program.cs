// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив: 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

try
{
    int m = ReadInt("Введите m");
    int n = ReadInt("Введите n");
    int[,] randomArray = Create2DArray(m, n);
    Print2DArray(randomArray);
    (int row, int column) = GetMinNumber(randomArray);
    int[,] resultArray = DeleteMinNumberRowAndColumn2DArray(randomArray, row, column);
    Print2DArray(resultArray);
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
            array[i, j] = random.Next(-10, 10);
        }
    }

    return array;
}

(int row, int column) GetMinNumber(int[,] array)
{
    int min = array[0, 0];
    int row = 0;
    int column = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < min)
            {
                min = array[i, j];
                row = i;
                column = j;
            }
        }
    }
    return (row, column);
}


int[,] DeleteMinNumberRowAndColumn2DArray(int[,] array, int row, int column)
{
    Console.WriteLine(row);
    Console.WriteLine(column);
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int resultI = 0;
    int resultJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (column != j)
            {
                result[resultI, resultJ] = array[i, j];
                resultJ++;
            }
        }
        if(row != i) 
            resultI++;
            resultJ = 0;
    }
    return result;
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
