// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33]

int num = int.Parse(Console.ReadLine());
string[] result = ArrayLength(num);
string[] resut = FillArray(result);
PrintArray(resut);


string[] ArrayLength(int number)
{
    string[] array = new string[number];
    return array;
}

string[] FillArray(string[] array)
{
    Console.WriteLine("Введите элементы массива через ЗАПЯТУЮ: ");
    string numbers = Console.ReadLine();
    array = numbers.Split(",");
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}
