// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int m;
int n;

try
{
    while (true)
    {
        m = ReadInt("Введите m");
        n = ReadInt("Введите n");
        if (m == n)
        {
            break;
        }
        Console.WriteLine("Введите одинаковые значения");
    }

    int[,] array = Create2DArray(m, n);
    Print2DArray(array);
    int[,] reverse = ChangeRowWithColumn(array);
    Console.WriteLine("REVERSE");
    Print2DArray(reverse);
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


int[,] ChangeRowWithColumn(int[,] array)
{
    int[,] resultArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            resultArray[i, j] = array[j, i];
        }
    }
    return resultArray;
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

