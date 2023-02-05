/* 
11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46 782 -> 72 918 -> 98 
Random random = new Random();
int randomNumber = random.Next(100, 1000);
Console.WriteLine(randomNumber);

int firstDigit = randomNumber / 100;
int lastDigit = randomNumber % 10;
int newNumber = firstDigit * 10 + lastDigit;

Console.WriteLine(newNumber);
*/

/* 
12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое 
число кратным второму. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 16, 4 -> кратно

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 % num2 == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("не кратно, остаток " + (num1 % num2));
}
*/

/* 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

14 -> нет 46 -> нет 161 -> да

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num % 7 == 0 & num % 23 == 0)
{
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("нет");
}
*/

/*16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число 
квадратом другого.

5, 25 -> да -4, 16 -> да 25, 5 -> да 8,9 -> нет*/


Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 * num1 == num2 || num2 * num2 == num1)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

