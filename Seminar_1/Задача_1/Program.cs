// Напишите программу, которая на вход принимает число
// и выдает ее квадрат
// Например 4 -> 16, 6 -> 36.

Console.WriteLine("Введите целое число - ");

int number = int.Parse(Console.ReadLine());

int result = number * number;

Console.WriteLine("Квадрат введенного числа - ");
Console.Write(result);
