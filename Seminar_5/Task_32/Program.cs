// Задача 32: Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
using Common;

int[] array = new int[] { 1, -2, 3, -4, 5, -6 };
int[] result = ChangeArray(array);
ArrayCommon.PrintArray(result);


int[] ChangeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -1 * array[i];
    }
    return array;
}