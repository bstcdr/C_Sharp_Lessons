// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2]-> 0
// [10, 11, 12, 13, 14]-> 5
using Common;

int[] array = CreateRandomArray(123);
int count = SearchCountNumber(array, 10, 99);
ArrayCommon.PrintArray(array);
Console.WriteLine($"Количество соответствующих чисел - {count}");


int[] CreateRandomArray(int size)
{
    Random random = new Random();
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(0, 201);
    }
    return array;
}


int SearchCountNumber(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= min && array[i] <= max)
        {
            count++;
        }       
    }
    return count;
}