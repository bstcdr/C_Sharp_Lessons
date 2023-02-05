// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью
// поэлементного копирования.
using Common;

int[] array = new int[] { 1, 5, 6, 8, 14 };
ArrayCommon.PrintArray(array);
int[] array2 = GetCopyOfArray(array);
ArrayCommon.PrintArray(array2);

int[] GetCopyOfArray(int[] array)
{
    int[] array2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array2[i] = array[i];
    }
    return array2;
}