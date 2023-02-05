// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Не использовать метод Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4-> 16

string[] numbers = FillArrayPow();
int resut = GetNumberPow(numbers);
PrintPow(resut);


string[] FillArrayPow()
{
    Console.WriteLine("Введите число и степень, в которую хотите возвести, через ЗАПЯТУЮ: ");
    string numbers = Console.ReadLine();
    string[] array = numbers.Split(",");
    return array;
}


void PrintPow(int result)
{
    Console.Write($"-> {result}");

}


int GetNumberPow(string[] num)
{
    int result = 1;
    if(int.Parse(num[1]) == 1)
    {
        result = int.Parse(num[0]);
    }
    else
    {
        for (int i = 0; i < int.Parse(num[1]); i++)
        {
            result *= int.Parse(num[0]);
        }
    }
    return result;
}
