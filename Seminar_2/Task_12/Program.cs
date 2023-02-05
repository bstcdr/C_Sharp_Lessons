// 12.Напишите программу, которая будет принимать на вход два числа и выводить, является ли 
// первое число кратным второму. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Write("Введите первое число - ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Введите второе число - ");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber % secondNumber == 0)
{
    Console.Write("Кратно");
}
else 
{
    int ostatok = firstNumber % secondNumber;
    Console.Write("Не кратно, остаток = " + ostatok);
}


// int ReadNumber(string text) {
//     Console.WriteLine(text);
//     int number;
//     string readNumber = Console.ReadLine();
//     if (int.TryParse(readNumber, out number)) {}
//     else
//     {

//     }
// }

