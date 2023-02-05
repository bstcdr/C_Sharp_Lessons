// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]-> 36 21
using Common;

int[] resultArray = new int[] {2, 9, 4, 5, 3, 7, 9, 15, 8};
ArrayCommon.PrintArray(resultArray);
int[] result = GetPairsMultiplication(resultArray);
ArrayCommon.PrintArray(result);


int[] GetPairsMultiplication(int[] array)
{
    int size = 0;
    if(array.Length % 2 == 0)
    {
        size = array.Length / 2;
    }
    else
    {
        size = array.Length / 2 + 1;
    }

    int[] resultArray = new int[size];

    if (array.Length % 2 == 0)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            resultArray[i] = array[i] * array[array.Length - 1 - i];
        }
    }
    else
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            resultArray[i] = array[i] * array[array.Length - 1 - i];
        }
        resultArray[resultArray.Length - 1] = array[array.Length / 2];
    }
    return resultArray;
}