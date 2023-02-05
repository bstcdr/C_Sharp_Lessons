// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int number = int.Parse(Console.ReadLine());
Console.WriteLine(GetBinaryFromDecimal(number));

string GetBinaryFromDecimal(int number)
{
    string text = String.Empty;
    for (int i = 0; 0 < number; i++)
    {
        text = number % 2 + text;
        number /= 2;
    }
    return text;
}