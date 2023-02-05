// Задача 28: Напишите программу, которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.
// 4->24 5->120


int number = int.Parse(Console.ReadLine());
Console.WriteLine(GetMultiplicationNumberBetweenOneToNumber(number));

int GetMultiplicationNumberBetweenOneToNumber(int num)
{
    int multip = 1;
    for (int i = 1; i <= num; i++)
    {
        multip *= i;
    }
    return multip;
}
