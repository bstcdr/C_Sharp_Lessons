// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3 78 -> 2 89126 -> 5

int number = int.Parse(Console.ReadLine());

Console.WriteLine(GetNumberLength(number));

int GetNumberLength(int number)
{
    int length = 0;
    while (number != 0)
    {
        number = number / 10;
        length++;
    }
    return length;
}












