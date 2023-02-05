// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int num = int.Parse(Console.ReadLine());
int res = GetSumOfEachNumber(num);
PrintSum(res);

int GetSumOfEachNumber(int number)
{
    int result = 0;
    while (number >= 10)
    {
        result = result + number % 10;
        number = number / 10;
    }
    result = result + number;
    return result;
}

void PrintSum(int result)
{
    Console.WriteLine($"Ответ -> {result}");
}