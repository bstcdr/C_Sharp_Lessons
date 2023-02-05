// Демонстрация решения
// Задача 31: Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и 
// положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.
using Common;

System.Console.Write("Random array - ");
int[] array = CreateRandomArray(4, -9, 9);
ArrayCommon.PrintArray(array);

int[] sumNegativeAndPositive = GetSumNegativeAndPositiveNumbers(array);
System.Console.Write("Sum Positive and Negative - ");
ArrayCommon.PrintArray(sumNegativeAndPositive);

// 1-Вариант
// int sumPositive = GetSumPositiveNumbers(array);
// Console.WriteLine($"Сумма положительных = {sumPositive}");
// int sumNegative = GetSumNegativeNumbers(array);
// Console.WriteLine($"Сумма отрицательных = {sumNegative}");

// 2-Вариант

/*int[] GetSumNegativeAndPositiveNumbers(int[] array)
{
    int[] sumNegativeAndPositive = new int[2];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumNegativeAndPositive[0] += array[i];
        }
        else
        {
            sumNegativeAndPositive[1] += array[i];
        }
    }
    return sumNegativeAndPositive;
}*/



int GetSumPositiveNumbers(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }

    return sum;
}


int GetSumNegativeNumbers(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }

    return sum;
}


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    Random random = new Random();
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}
