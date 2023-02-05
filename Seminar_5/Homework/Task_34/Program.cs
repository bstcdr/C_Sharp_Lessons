// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
using Common;

int[] randomArray = CreateRandomArray(8);
ArrayCommon.PrintArray(randomArray);
Console.WriteLine($"Количество четных чисел - {FindCountEvenNumber(randomArray)}");

int FindCountEvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 ==0)
        {
            count++;
        }
    }
    return count;
}




int[] CreateRandomArray(int size)
{
    Random random = new Random();
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}