// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[] { 25, 27, 16, 67, 289, 74, 1189};
Console.WriteLine($"Разность максимального и минимального элемента - {FindDeltaMaxMinElement(array)}");

double FindDeltaMaxMinElement(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];
    }
    double deltaMaxMin = max - min;
    return deltaMaxMin;
}