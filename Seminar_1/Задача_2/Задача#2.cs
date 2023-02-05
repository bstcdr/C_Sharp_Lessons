/* 1.Напишите программу, которая на вход принимает два числа и проверяет, 
является ли первое число квадратом второго. 
a = 25, b = 5->да a = 2, b = 10->нет a = 9, b = -3->да a = -3 b = 9 -> нет 20 мин */

Console.WriteLine("Введите два числа - ");

int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

int result = number2 * number2;

if (number1 == result)
{
    Console.WriteLine("Да, является");
}
else
{
    Console.WriteLine("Нет, не является");
}