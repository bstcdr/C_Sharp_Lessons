// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0
using Common;

int[] randomArray = CreateRandomArray(8);
ArrayCommon.PrintArray(randomArray);
Console.WriteLine($"Сумма четных чисел - {FindSumOfEvenNumber(randomArray)}");

int FindSumOfEvenNumber(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum += array[i];
        }
    }
    return sum;
}


int[] CreateRandomArray(int size)
{
    Random random = new Random();
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(1, 1000);
    }
    return array;
}