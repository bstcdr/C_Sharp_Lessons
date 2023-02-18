// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3, 4, 6, 1, 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

try
{
    int m = ReadInt("Введите m");
    int n = ReadInt("Введите n");
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

int[] FindAllElementsOf2DArray(int[,] array)
{
    int[] resultArray = new int[];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
        }
    }
}

int[,] FindQuantityOfTheSameElement2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
        }
    }
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

