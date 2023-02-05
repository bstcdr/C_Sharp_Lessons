// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Ai,j = i + j.
// Выведите полученный массив на экран.
// m = 3, n = 4. 
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

try
{
    int m = ReadInt("Введите m");
    int n = ReadInt("Введите n");
    int[,] array2D = Create2DArrayWithSumOfEachIndex(m, n);
    Print2DArray(array2D);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

int[,] Create2DArrayWithSumOfEachIndex(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


int ReadInt(string title)
{
    Console.WriteLine(title);
    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if(isParsed)
    {
        return (number);
    }

    throw new Exception("Введены некорректные числа!");
}