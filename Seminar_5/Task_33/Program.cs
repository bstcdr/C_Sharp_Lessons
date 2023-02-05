// Задача 33: Задайте массив.Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив[6, 7, 19, 345, 3]->нет
// 3; массив[6, 7, 19, 345, 3]->да

int[] array = new int[] { 25, 28, -3, 6, 14, -78 };
Console.WriteLine(SearchNumberInArray(25, array));


string SearchNumberInArray(int number, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            return "-> да";
        }
    }
    return "-> нет";
}